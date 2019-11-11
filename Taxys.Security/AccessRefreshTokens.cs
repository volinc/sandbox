namespace Taxys.Security
{
    /// <summary>
    /// Содержит данные токенов доступа и обновления.
    /// </summary>
    public class AccessRefreshTokens
    {
        /// <summary>
        /// Возвращает данные токена аутентификации.
        /// </summary>
        public Payload Access { get; }

        /// <summary>
        /// Возвращает данные токена обновления.
        /// </summary>
        public Payload Refresh { get; }

        /// <summary>
        /// Инициализирует новый экземпляр типа <see cref="AccessRefreshTokens"/>.
        /// </summary>
        /// <param name="access"></param>
        /// <param name="refresh"></param>
        public AccessRefreshTokens(Payload access, Payload refresh)
        {
            Access = access;
            Refresh = refresh;
        }
    }
}