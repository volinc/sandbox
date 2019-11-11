namespace Taxys.Security
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Runtime.Serialization;
    using System.Security.Claims;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Описывает набор полей, включаемых в <see cref="!:https://jwt.io/introduction/">JSON Web Token</see>.
    /// </summary>
    [DataContract]
    public class Payload
    {
        public const string ClaimTypeAudience = "http://taxys.ru/schema/claims/audience";
        
        public const string ClaimTypeUserUuid = "http://taxys.ru/schema/claims/user-uuid";

        public const string ClaimTypeOrganizationId = "http://taxys.ru/schema/claims/organization-id";

        public const string ClaimTypeOrganizationUuid = "http://taxys.ru/schema/claims/organization-uuid";

        public const string ClaimTypeLogin = "http://taxys.ru/schema/claims/login";

        public const string ClaimTypeTokenId = "http://taxys.ru/schema/claims/token-id";

        /// <summary>
        /// Название поля «тип токена». Содержит строку "access" или "refresh".
        /// </summary>
        public const string ClaimTypeTokenType = "http://taxys.ru/schema/claims/token-type";

        /// <summary>
        /// Возвращает и задает идентификатор пользователя.
        /// </summary>
        [DataMember(Name = "sub")]
        [JsonPropertyName("sub")]
        public long UserId { get; set; }

        /// <summary>
        /// Возвращает или задает глобальный идентификатор пользователя, если есть.
        /// </summary>
        /// <remarks>
        /// Это поле заполнено только для пользователей обладающих счетом.
        /// </remarks>
        [DataMember(Name = "sub_uuid")]
        [JsonPropertyName("sub_uuid")]
        public Guid? UserUuid { get; set; }

        /// <summary>
        /// Возвращает и задает роль пользователя.
        /// </summary>
        [DataMember(Name = "role")]
        [JsonPropertyName("role")]
        public string Role { get; set; }

        /// <summary>
        /// Возвращает и задает время окончания действия токена.
        /// </summary>
        /// <remarks>
        /// Задается в UTC, в секундах с 1 января 1970 года.
        /// </remarks>
        [DataMember(Name = "exp")]
        [JsonPropertyName("exp")]
        public long ExpireUnixTimeSeconds { get; set; }

        /// <summary>
        /// Возвращает и задает имя пользователя.
        /// </summary>
        [DataMember(Name = "name")]
        [JsonPropertyName("name")]
        public string Username { get; set; }

        /// <summary>
        /// Возвращает и задает логин пользователя.
        /// </summary>
        [DataMember(Name = "login")]
        [JsonPropertyName("login")]
        public string Login { get; set; }

        /// <summary>
        /// Возвращает и задает идентификатор организации, если есть.
        /// </summary>
        /// <remarks>
        /// Это поле заполнено только для сотрудников организаций.
        /// </remarks>
        [DataMember(Name = "org")]
        [JsonPropertyName("org")]
        public long? OrganizationId { get; set; }

        /// <summary>
        /// Возвращает или задает глобальный идентификатор организации, если есть.
        /// </summary>
        /// <remarks>
        /// Это поле заполнено только для сотрудников организаций.
        /// </remarks>
        [DataMember(Name = "org_uuid")]
        [JsonPropertyName("org_uuid")]
        public Guid? OrganizationUuid { get; set; }

        /// <summary>
        /// Возвращает и задает уникальный идентификатор токена.
        /// </summary>
        [DataMember(Name = "jti")]
        [JsonPropertyName("jti")]
        public Guid TokenId { get; set; }

        /// <summary>
        /// Возвращает и задает тип токена: "access" или "refresh".
        /// </summary>
        [DataMember(Name = "type")]
        [JsonPropertyName("type")]
        public string TokenType { get; set; }

        /// <summary>
        /// Возвращает и задает точку входа, через которую получен токен.
        /// </summary>
        [DataMember(Name = "aud")]
        [JsonPropertyName("aud")]
        public string Audience { get; set; }

        /// <summary>
        /// Конвертирует содержимое токена в объект <see cref="ClaimsPrincipal"/>.
        /// </summary>
        /// <returns>Объект <see cref="ClaimsPrincipal"/> содержащий утверждения, извлеченные из токена.</returns>
        public ClaimsPrincipal ToPrincipal()
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, UserId.ToString(NumberFormatInfo.InvariantInfo)),
                
                // Используем потому, что ClaimsPrincipal.IsInRole будет искать claim с именем
                // ClaimsIdentity.RoleClaimType, который по умолчанию ссылается на ClaimTypes.Role.
                // https://msdn.microsoft.com/en-us/library/system.security.claims.claimsprincipal.isinrole(v=vs.110).aspx
                new Claim(ClaimTypes.Role, Role),                

                new Claim(ClaimTypeAudience, Audience),
                new Claim(ClaimTypeTokenId, TokenId.ToString("N")),
            };

            if (UserUuid.HasValue)
                claims.Add(new Claim(ClaimTypeUserUuid, UserUuid.Value.ToString("N")));

            if (OrganizationId.HasValue)
                claims.Add(new Claim(ClaimTypeOrganizationId, OrganizationId.Value.ToString(NumberFormatInfo.InvariantInfo)));

            if (OrganizationUuid.HasValue)
                claims.Add(new Claim(ClaimTypeOrganizationUuid, OrganizationUuid.Value.ToString("N")));

            if (!string.IsNullOrWhiteSpace(Login))
                claims.Add(new Claim(ClaimTypeLogin, Login));

            // AuthenticationTypes.Password используем, потому что без него
            // ClaimsIdentity.IsAuthenticated будет возвращать false.
            // http://stackoverflow.com/questions/20254796/why-is-my-claimsidentity-isauthenticated-always-false-for-web-api-authorize-fil
            var identity = new ClaimsIdentity(claims,  "Password");

            return new ClaimsPrincipal(identity);
        }
    }
}