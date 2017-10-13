namespace Forms.Driving.Domain
{
    /// <summary>
    /// Описывает уведомление полученное от сервера.
    /// </summary>
    public class Notification
    {
        public Notification(NotificationType type, object data)
        {
            Type = type;
            Data = data;
        }

        /// <summary>
        /// Возвращает тип уведомления.
        /// </summary>
        public NotificationType Type { get; }

        /// <summary>
        /// Возвращает данные уведомления.
        /// </summary>
        public object Data { get; }
    }
}
