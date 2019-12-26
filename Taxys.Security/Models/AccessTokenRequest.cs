namespace Taxys.Security.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Набор данных, необходимых для аутентификации в соответствии со стандартом
    /// <see cref="!:https://tools.ietf.org/html/rfc6749#section-4.3.2">RFC 6749</see>.
    /// </summary>
    [DataContract]
    public class AccessTokenRequest
    {
        /// <summary>
        /// Тип авторизации в соответствии со стандартом
        /// <see cref="!:https://tools.ietf.org/html/rfc6749">OAuth 2.0</see>. Поддерживаются
        /// значения <c>password</c> (https://tools.ietf.org/html/rfc6749#section-4.3),
        /// <c>refresh_token</c> (https://tools.ietf.org/html/rfc6749#section-6).
        /// </summary>
        [Required]
        [DataMember(Name="grant_type")]
        [JsonPropertyName("grant_type")]
        public string GrantType { get; set; }

        /// <summary>
        /// Логин пользователя.
        /// Адрес электронной почты или номер телефона. Номер телефона должен содержать только цифры
        /// и включать код страны, например, "79875554433". Поле используется при аутентификации <c>password</c>.
        /// </summary>
        [DataMember(Name="username")]
        [JsonPropertyName("username")]
        public string Username { get; set; }

        /// <summary>
        /// Пароль пользователя. Поле используется при аутентификации <c>password</c>.
        /// </summary>
        [DataMember(Name="password")]
        [JsonPropertyName("password")]
        public string Password { get; set; }

        /// <summary>
        /// Одноразовый код. Поле используется при аутентификации <c>http://taxys.ru/schema/grants/passwordless</c>.
        /// </summary>
        [DataMember(Name="code")]
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// Токен обновления. Поле используется при аутентификации <c>refresh_token</c>.
        /// </summary>
        [DataMember(Name="refresh_token")]
        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }
    }
}