namespace Taxys.Security.Models
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Представление набора данных, описывающих токен аутентификации.
    /// </summary>
    /// <remarks>Подробности d <see cref="!:https://tools.ietf.org/html/rfc6749#section-5.1">RFC 6749</see>.</remarks>
    [DataContract]
    public class AccessTokenResponse
    {
        /// <summary>
        /// Токен доступа.
        /// </summary>
        [DataMember(Name="access_token")]        
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// Тип токена.
        /// Поле содержит <see cref="!:https://tools.ietf.org/html/rfc6749#section-7.1">строку "bearer"</see>.
        /// </summary>
        [DataMember(Name="token_type")]
        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }

        /// <summary>
        /// Время жизни токена в секундах.
        /// </summary>
        [DataMember(Name="expires_in")]
        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// Токен обновления.
        /// </summary>
        [DataMember(Name="refresh_token")]
        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }
    }
}