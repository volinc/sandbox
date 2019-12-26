namespace Taxys.Security
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Security.Claims;
    using System.Security.Principal;

    /// <summary>
    /// Реализует методы расширения для работы с идентичностью пользователя.
    /// </summary>
    public static class IdentityExtension
    {
        /// <summary>
        /// Возвращает точку входа к которой предоставляется доступ.
        /// </summary>
        public static string GetAudience(this IIdentity identity)
        {
            return identity.GetClaim<string>(Payload.ClaimTypeAudience);
        }

        /// <summary>
        /// Возвращает идентификатор пользователя.
        /// </summary>
        public static long GetId(this IIdentity identity)
        {
            return identity.GetClaim<long>(ClaimTypes.NameIdentifier);
        }
        
        /// <summary>
        /// Возвращает роль пользователя.
        /// </summary>
        public static string GetRole(this IIdentity identity)
        {
            return identity.GetClaim<string>(ClaimTypes.Role);
        }

        /// <summary>
        /// Возвращает глобальный идентификатор пользователя.
        /// </summary>
        public static Guid GetUuid(this IIdentity identity)
        {
            var claimsIdentity = (ClaimsIdentity)identity;
            var claim = claimsIdentity.Claims.Single(x => x.Type == Payload.ClaimTypeUserUuid);

            return Guid.Parse(claim.Value);
        }

        /// <summary>
        /// Возвращает идентификатор организации (компании) пользователя.
        /// </summary>
        public static long GetOrganizationId(this IIdentity identity)
        {
            return identity.GetClaim<long>(Payload.ClaimTypeOrganizationId);
        }

        /// <summary>
        /// Возвращает глобальный идентификатор организации (компании) пользователя.
        /// </summary>
        public static Guid GetOrganizationUuid(this IIdentity identity)
        {
            var claimsIdentity = (ClaimsIdentity)identity;
            var claim = claimsIdentity.Claims.Single(x => x.Type == Payload.ClaimTypeOrganizationUuid);

            return Guid.Parse(claim.Value);
        }

        /// <summary>
        /// Возвращает идентификатор организации (компании) пользователя, если есть.
        /// </summary>
        public static bool TryGetOrganizationId(this IIdentity identity, out long organizationId)
        {
            var claimsIdentity = (ClaimsIdentity)identity;
            var claim = claimsIdentity.Claims.SingleOrDefault(x => x.Type == Payload.ClaimTypeOrganizationId);

            var claimValue = claim == null
                ? null as long?
                : long.Parse(claim.Value, NumberStyles.Any, CultureInfo.InvariantCulture);

            if (!claimValue.HasValue)
            {
                organizationId = default;
                return false;
            }

            organizationId = claimValue.Value;
            return true;
        }

        /// <summary>
        /// Возвращает логин пользователя.
        /// </summary>
        public static string GetLogin(this IIdentity identity)
        {
            return identity.GetClaim<string>(Payload.ClaimTypeLogin);
        }

        private static long? GetClaim(this IIdentity identity, string type)
        {
            var claimsIdentity = (ClaimsIdentity)identity;
            var claim = claimsIdentity.Claims.SingleOrDefault(x => x.Type == type);

            return claim == null
                ? null as long?
                : long.Parse(claim.Value, NumberStyles.Any, CultureInfo.InvariantCulture);
        }

        private static T GetClaim<T>(this IIdentity identity, string type)
            where T : IConvertible
        {
            try
            {
                var claimsIdentity = (ClaimsIdentity)identity;
                var value = claimsIdentity.Claims
                                          .Single(x => x.Type == type)
                                          .Value;

                if (typeof(T).IsEnum)
                    return (T)Enum.Parse(typeof(T), value);

                return (T)Convert.ChangeType(value, typeof(T));
            }
            catch (OverflowException exception)
            {
                throw new InvalidOperationException($"Value '{type}' is bigger than {typeof(T).FullName} can contain.", exception);
            }
            catch (ArgumentException exception)
            {
                throw new InvalidOperationException($"Can't cast '{type}' value to {typeof(T).FullName}.", exception);
            }
            catch (InvalidOperationException exception)
            {
                throw new InvalidOperationException($"There's not claim of type {typeof(T).FullName} with claim '{type}'.", exception);
            }
        }
    }
}