namespace Taxys.Security
{        
    public class SecurityConfiguration
    {
        /// <summary>
        /// Возвращает или задает алгоритм подписания токена.
        /// </summary>
        public string SigningAlgorithm { get; set; }        

        /// <summary>
        /// Возвращает или задает алгоритм шифрования токена.
        /// </summary>
        public string EncryptingAlgorithm { get; set; }        

        /// <summary>
        /// Возвращает или задает пароль для шифрования токенов.
        /// </summary>
        /// <remarks>
        /// Пароль хранится в виде шестнадцатиричной строки, длина которой должна соответствовать алгоритму шифрования.
        /// </remarks>
        public byte[] TokenPassword { get; set; }                
    }
}