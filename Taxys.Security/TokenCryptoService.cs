namespace Taxys.Security
{
    using System;
    using Jose;

    /// <summary>
    /// Реализует методы конвертации объекта <see cref="Payload"/> в зашифрованный JSON Web Token, и обратно.
    /// </summary>
    public class TokenCryptoService
    {
        private readonly JweAlgorithm signingAlgorithm;
        private readonly JweEncryption encryptingAlgorithm;
        private readonly byte[] key;

        /// <summary>
        /// Инициализирует объект типа <see cref="TokenCryptoService"/> с указанной конфигурацией безопасности.
        /// </summary>
        /// <param name="configuration">Конфигурация безопасности.</param>
        public TokenCryptoService(SecurityConfiguration configuration)
        {
            signingAlgorithm = (JweAlgorithm) Enum.Parse(typeof (JweAlgorithm), configuration.SigningAlgorithm);
            encryptingAlgorithm = (JweEncryption) Enum.Parse(typeof (JweEncryption), configuration.EncryptingAlgorithm);
            key = configuration.TokenPassword;
        }

        /// <summary>
        /// Расшифровывает данные пользователя из токена.
        /// </summary>
        /// <param name="token">Строковый токен JWE.</param>
        /// <param name="payload">Данные пользователя.</param>
        /// <returns>
        /// <c>true</c>, если токен может быть расшифрован и конвертирован;
        /// в противном случае <c>false</c>.
        /// </returns>
        public bool TryDecrypt(string token, out Payload payload)
        {
            try
            {
                payload = JWT.Decode<Payload>(token, key);
                return true;
            }
            catch
            {
                payload = null;
                return false;
            }
        }

        /// <summary>
        /// Шифрует данные пользователя в токен.
        /// </summary>
        /// <param name="payload">Данные пользователя.</param>
        /// <returns>Строковый токен JWE.</returns>
        public string Encrypt(Payload payload) => JWT.Encode(payload, key, signingAlgorithm, encryptingAlgorithm);

        /// <summary>
        /// Шифрует идентификатор пользователя в токен.
        /// </summary>
        /// <param name="userId">Идентификатор пользователя.</param>
        /// <returns></returns>
        public string Encrypt(long userId) => JWT.Encode(userId, key, signingAlgorithm, encryptingAlgorithm);
    }
}