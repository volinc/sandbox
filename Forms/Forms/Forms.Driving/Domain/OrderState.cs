namespace Forms.Driving.Domain
{
    /// <summary>
    /// Перечисляет состояния заказа.
    /// </summary>
    public enum OrderState : long
    {
        /// <summary>
        /// Неизвестное состояние.
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Доезд.
        /// </summary>
        /// <remarks>Водитель принял заказ и поехал на адрес.</remarks>
        Arrival = 50,

        /// <summary>
        /// Ожидание.
        /// </summary>
        /// <remarks>Водитель на адресе ждет выхода пассажира.</remarks>
        Waiting = 60,

        /// <summary>
        /// Исполнение.
        /// </summary>
        /// <remarks>Водитель везет пассажира.</remarks>
        Executing = 70,

        /// <summary>
        /// Исполнен.
        /// </summary>
        /// <remarks>Водитель довез пассажира.</remarks>
        Finished = 80,

        /// <summary>
        /// Закрыт. Пассажир расплатился с водителем.
        /// </summary>
        Closed = 90,
    }
}