namespace Taxys.Security
{
    /// <summary>
    /// Содержит минимальный набор данных, которые должен содержать токен обновления,
    /// чтобы восстановить полную информацию о пользователе.
    /// </summary>
    public class MiniUser
    {
        /// <summary>
        /// Возвращает или задает идентификатор пользователя.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Возвращает или задает электронный адрес или номер телефона пользователя.
        /// </summary>
        public string Login { get; set; }
    }
}