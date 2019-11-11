namespace Taxys.Security
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Security.Authentication;
    using System.Threading.Tasks;
    using MessagePack;
    using MessagePack.Resolvers;
    using Microsoft.Extensions.Caching.Distributed;
    using Newtonsoft.Json;
    using Taxys.Domain;
    using Taxys.Security.Models;

    /// <summary>
    /// Реализует методы аутентификации, общие для разных точек входа.
    /// </summary>
    public class AuthenticationService
    {
        public delegate Task<User> ValidateAsync(bool isPasswordles = false);

        /// <summary>
        /// Аутентификация по паролю.
        /// </summary>
        public const string GrantPassword = "password";

        /// <summary>
        /// Аутентификация по одноразовому коду.
        /// </summary>
        public const string GrantPasswordless = "http://taxys.ru/schema/grants/passwordless";

        /// <summary>
        /// Аутентификация по токену обновления.
        /// </summary>
        public const string GrantRefreshToken = "refresh_token";

        /// <summary>
        /// Тип токена доступа.
        /// </summary>
        private const string AccessTokenType = "access";

        /// <summary>
        /// Тип токена обновления.
        /// </summary>
        private const string RefreshTokenType = "refresh";

        private static readonly string[] ValidGrants =
        {
            GrantPassword,
            GrantPasswordless,
            GrantRefreshToken,
        };
        
        private readonly Func<DateTimeOffset> now;
        private readonly TokenCryptoService tokenCryptoService;
        private readonly IDistributedCache cache;

        /// <summary>
        /// Время жизни access_token (см. 4.2.2 https://tools.ietf.org/html/rfc6749).
        /// </summary>
        public TimeSpan AccessTokenLifetime { get; }

        /// <summary>
        /// Время жизни refresh_token (см. 10.4 https://tools.ietf.org/html/rfc6749).
        /// </summary>
        public TimeSpan RefreshTokenLifetime { get; }

        public AuthenticationService(Func<DateTimeOffset> now, 
                                     TokenCryptoService tokenCryptoService, 
                                     IDistributedCache cache,
                                     TimeSpan accessTokenLifetime, 
                                     TimeSpan refreshTokenLifetime)
        {
            this.now = now;
            this.tokenCryptoService = tokenCryptoService;
            this.cache = cache;            
            AccessTokenLifetime = accessTokenLifetime;
            RefreshTokenLifetime = refreshTokenLifetime;
        }

        /// <summary>
        /// Бросает исключение <see cref="AuthenticationException"/>, если
        /// нераспознанный тип аутентификации.
        /// </summary>
        /// <param name="grantType">Тип аутентификации.</param>
        public void ThrowIfInvalidGrantType(string grantType)
        {
            if (!ValidGrants.Contains(grantType, StringComparer.InvariantCulture))
                throw new AuthenticationException("Incorrect grant type.");
        }

        /// <summary>
        /// Создает токен аутентификации и сохраняет его на время жизни токенов.
        /// </summary>
        /// <param name="audience">Точка входа: driver, aggregator, passenger, employer, job.</param>
        /// <param name="user">Идентификатор пользователя.</param>
        /// <param name="role">Роль пользователя.</param>
        /// <param name="username">Имя пользователя.</param>
        /// <param name="userUuid"></param>
        /// <param name="organizationId">Организация пользователя.</param>
        /// <param name="organizationUuid"></param>
        /// <returns>Токен аутентификации.</returns>
        public AccessRefreshTokens CreateAccessRefreshTokens(string audience, MiniUser user, string role,
                                                             string username = null, Guid? userUuid = null,
                                                             long? organizationId = null, Guid? organizationUuid = null)
        {
            var accessToken = CreateAccessToken(audience, user.Id, role, username, userUuid, organizationId, organizationUuid, user.Login);
            var refreshToken = CreateRefreshToken(audience, user.Id, user.Login);

            return new AccessRefreshTokens(accessToken, refreshToken);
        }

        /// <summary>
        /// Сохраняет токены в кэше.
        /// </summary>
        /// <param name="tokens">Токены доступа и обновления.</param>
        public async Task StoreTokensToCacheAsync(AccessRefreshTokens tokens)
        {
            var key = MakeCacheKey(tokens.Access.Audience, tokens.Access.UserId);

            await AddOrUpdateStoredTokenAsync(key, tokens);
        }

        private async Task AddOrUpdateStoredTokenAsync(string key, AccessRefreshTokens tokens)
        {
            var bytes = MessagePackSerializer.Serialize(tokens, ContractlessStandardResolver.Instance);

            await cache.SetAsync(key, bytes, new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = RefreshTokenLifetime
            });
        }

        /// <summary>
        /// Создает ответ для отправки пользователю.
        /// </summary>
        /// <param name="tokens"></param>
        /// <returns>JSON, описанный в <see cref="!:https://tools.ietf.org/html/rfc6749#section-5.1">RFC-6749</see>.</returns>
        public AccessTokenResponse CreateResponse(AccessRefreshTokens tokens)
        {
            return new AccessTokenResponse
            {
                AccessToken = tokenCryptoService.Encrypt(tokens.Access),
                RefreshToken = tokenCryptoService.Encrypt(tokens.Refresh),
                ExpiresIn = (int)AccessTokenLifetime.TotalSeconds,
                TokenType = "bearer",
            };
        }

        public bool TryDecryptAccessPayload(string accessToken, out Payload accessPayload)
        {
            return TryDecryptToken(accessToken, AccessTokenType, out accessPayload);
        }

        public async Task<bool> IsAccessPayloadStoredAsync(Payload accessPayload)
        {
            var key = MakeCacheKey(accessPayload.Audience, accessPayload.UserId);
            
            var conditionalAccessRefreshTokens = await TryGetStoredTokenAsync(key);
            if (conditionalAccessRefreshTokens.HasValue)
                return accessPayload.TokenId == conditionalAccessRefreshTokens.Value.Access.TokenId;

            return false;
        }

        private bool TryDecryptRefreshPayload(string refreshToken, out Payload refreshPayload)
        {
            return TryDecryptToken(refreshToken, RefreshTokenType, out refreshPayload);
        }

        private async Task<bool> IsRefreshTokenStoredAsync(Payload refreshPayload)
        {
            var key = MakeCacheKey(refreshPayload.Audience, refreshPayload.UserId);

            var conditionalAccessRefreshTokens = await TryGetStoredTokenAsync(key);
            if (conditionalAccessRefreshTokens.HasValue)
                return refreshPayload.TokenId == conditionalAccessRefreshTokens.Value.Refresh.TokenId;

            return false;
        }

        private async Task<ConditionalValue<AccessRefreshTokens>> TryGetStoredTokenAsync(string key)
        {
            try
            {
                var bytes = await cache.GetAsync(key);
                if (bytes == null)
                    return ConditionalValue<AccessRefreshTokens>.None;

                var value = MessagePackSerializer.Deserialize<AccessRefreshTokens>(bytes, ContractlessStandardResolver.Instance);
                return new ConditionalValue<AccessRefreshTokens>(value);
            }
            catch
            {
                // todo: исправить после конвертации всех токенов через MessagePackSerializer
                try
                {
                    var json = await cache.GetStringAsync(key);
                    if (json == null)
                        return ConditionalValue<AccessRefreshTokens>.None;

                    var value = JsonConvert.DeserializeObject<AccessRefreshTokens>(json);
                    return new ConditionalValue<AccessRefreshTokens>(value);
                }
                catch
                {
                    return ConditionalValue<AccessRefreshTokens>.None;
                }
            }
        }

        /// <summary>
        /// Удаляет токены из кэша.
        /// </summary>
        /// <param name="audience">Точка входа: "driver", "aggregator", "passenger", "employer".</param>
        /// <param name="userId">Идентификатор пользователя.</param>
        public async Task RemoveTokensFromCacheAsync(string audience, long userId)
        {
            var key = MakeCacheKey(audience, userId);

            await cache.RemoveAsync(key);
        }

        public async Task<MiniUser> AuthenticateAsync(AccessTokenRequest request, string audience, ValidateAsync validate)
        {
            return request.GrantType switch
            {
                GrantPassword => await GetGrantPasswordAsync(request, audience, validate),
                GrantRefreshToken => await GetGrantRefreshTokenAsync(request),
                GrantPasswordless => await GetGrantPasswordless(request, audience, validate),
                _ => throw new AuthenticationException("Incorrect grant type."),
            };
        }

        private async Task<MiniUser> GetGrantPasswordAsync(AccessTokenRequest request, string audience, ValidateAsync validate)
        {
            var user = await AuthenticateByPasswordAsync(audience, validate);

            return new MiniUser {Id = user.Id, Login = request.Username};
        }

        private async Task<MiniUser> GetGrantRefreshTokenAsync(AccessTokenRequest request)
        {
            if (TryDecryptRefreshPayload(request.RefreshToken, out var refreshPayload))
            {
                if (await IsRefreshTokenStoredAsync(refreshPayload))
                {
                    return new MiniUser
                    {
                        Id = refreshPayload.UserId,
                        Login = refreshPayload.Login
                    };
                }
            }

            throw new AuthenticationException("Incorrect refresh token.");
        }

        private async Task<MiniUser> GetGrantPasswordless(AccessTokenRequest request, string audience, ValidateAsync validate)
        {
            var user = await AuthenticateByCodeAsync(audience, validate);

            return new MiniUser { Id = user.Id, Login = request.Username };
        }

        private async Task<User> AuthenticateByPasswordAsync(string audience, ValidateAsync validate)
        {
            var user = await validate(false);

            await RemoveTokensFromCacheAsync(audience, user.Id);
            return user;
        }

        private async Task<User> AuthenticateByCodeAsync(string audience, ValidateAsync validate)
        {
            var user = await validate(true);

            await RemoveTokensFromCacheAsync(audience, user.Id);
            return user;
        }

        private static string MakeCacheKey(string audience, long userId)
        {
            return $"Token-{audience}-{userId.ToString(CultureInfo.InvariantCulture)}";
        }

        /// <summary>
        /// Создает токен аутентификации.
        /// </summary>
        /// <param name="audience">Точка входа.</param>
        /// <param name="userId">Идентификатор пользователя.</param>
        /// <param name="role">Роль пользователя.</param>
        /// <param name="username">Имя пользователя.</param>
        /// <param name="userUuid">Глобальный идентификатор пользователя.</param>
        /// <param name="organizationId">Идентификатор организации.</param>
        /// <param name="organizationUuid">Глобальный идентификатор организации.</param>
        /// <param name="login">Логин пользователя.</param>
        /// <returns>Токен аутентификации.</returns>
        private Payload CreateAccessToken(string audience, long userId, string role, string username = null,
                                          Guid? userUuid = null, long? organizationId = null,
                                          Guid? organizationUuid = null, string login = null)
        {
            var payload = new Payload
            {
                Audience = audience,
                UserId = userId,
                UserUuid = userUuid,
                Username = username,
                OrganizationId = organizationId,
                OrganizationUuid = organizationUuid,
                Login = login,
                Role = role,
                ExpireUnixTimeSeconds = (now() + AccessTokenLifetime).ToUnixTimeSeconds(),
                TokenId = Guid.NewGuid(),
                TokenType = AccessTokenType,
            };

            return payload;
        }

        /// <summary>
        /// Создает токен обновления на основании идентификатора пользователя.
        /// </summary>
        /// <param name="audience">Точка входа.</param>
        /// <param name="userId">Идентификатор пользователя.</param>
        /// <param name="login">Логин пользователя: электронный адрес или номер телефона.</param>
        /// <returns>Токен обновления.</returns>
        private Payload CreateRefreshToken(string audience, long userId, string login)
        {
            return new Payload
            {
                Audience = audience,
                UserId = userId,
                Login = login,
                ExpireUnixTimeSeconds = (now() + RefreshTokenLifetime).ToUnixTimeSeconds(),
                TokenId = Guid.NewGuid(),
                TokenType = RefreshTokenType
            };
        }

        /// <summary>
        /// Расшифровывает токен, затем проверяет тип и время жизни.
        /// </summary>
        /// <param name="token">Токен.</param>
        /// <param name="tokenType">Тип токена.</param>
        /// <param name="payload">Информация о пользователе.</param>
        /// <returns></returns>
        private bool TryDecryptToken(string token, string tokenType, out Payload payload)
        {
            if (!tokenCryptoService.TryDecrypt(token, out payload))
                return false;

            if (payload.TokenType != tokenType)
                return false;

            if (IsDead(payload.ExpireUnixTimeSeconds))
                return false;

            return true;
        }

        /// <summary>
        /// Проверяет время жизни токена.
        /// </summary>
        /// <param name="expireUnixTimeSeconds"></param>
        /// <returns></returns>
        private bool IsDead(long expireUnixTimeSeconds)
        {
            return now() > DateTimeOffset.FromUnixTimeSeconds(expireUnixTimeSeconds);
        }
    }
}