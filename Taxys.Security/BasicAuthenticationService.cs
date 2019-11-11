namespace Taxys.Security
{
    using System;
    using System.Security.Cryptography;
    using System.Text;
    using Microsoft.Extensions.Primitives;

    /// <summary>
    /// Проверяет корректность логина/пароля при BASIC-аутентификации. 
    /// </summary>
    public class BasicAuthenticationService
    {
        private readonly string salt;

        /// <summary>
        /// Инициализирует новый экземпляр типа <see cref="BasicAuthenticationService"/>.
        /// </summary>
        public BasicAuthenticationService(string salt)
        {
            this.salt = salt;
        }

        /// <summary>
        /// Проверяет все заголовки авторизации HTTP запроса.
        /// </summary>
        /// <param name="authorizationHeaders">Заголовки Authorization.</param>
        /// <param name="login">Логин компании-агрегатора, заходированный в заголовке.</param>
        public bool TryExtractLogin(StringValues authorizationHeaders, out string login)
        {
            foreach (string authorizationHeader in authorizationHeaders)
            {
                if (ValidateAuthorizationHeader(authorizationHeader, out login))
                    return true;
            }

            login = null;
            return false;
        }

        internal bool ValidateAuthorizationHeader(string authorizationHeader, out string login)
        {
            login = null;

            var pairs = authorizationHeader.Split(' ');

            if (pairs.Length != 2)
                return false;

            if (!pairs[0].Equals("basic", StringComparison.OrdinalIgnoreCase))
                return false;

            var loginPasswordBytes = Convert.FromBase64String(pairs[1]);
            var loginPassword = Encoding.UTF8
                                        .GetString(loginPasswordBytes)
                                        .Split(':');

            if (loginPassword.Length != 2)
                return false;

            login = loginPassword[0];
            var password = loginPassword[1];
            var computedPassword = ComputePasswordByLogin(loginPassword[0]);

            return password == computedPassword;
        }

        /// <summary>
        /// Вычисляет пароль по логину.
        /// </summary>
        /// <remarks>
        /// Для безопасности используется секретная затравка, известная только серверу.
        /// </remarks>
        /// <param name="login">Логин.</param>
        /// <returns>Пароль.</returns>
        public string ComputePasswordByLogin(string login)
        {
            var stringBuilder = new StringBuilder();

            using (var md5 = MD5.Create())
            {
                var loginSaltBytes = Encoding.UTF8.GetBytes(login + salt);
                var passwordBytes = md5.ComputeHash(loginSaltBytes);

                foreach (var passwordByte in passwordBytes)
                    stringBuilder.AppendFormat("{0:X2}", passwordByte);
            }

            return stringBuilder.ToString();
        }
    }
}