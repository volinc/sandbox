namespace Forms.Driving.Domain
{
    /// <summary>
    /// Перечисляет причины завершения заказа.
    /// </summary>
    public enum OrderCompletionReason : long
    {
        /// <summary>
        /// Оплачен.
        /// </summary>
        /// <remarks>
        /// Водитель довез пассажира до конечной точки маршрута и получил деньги.
        /// </remarks>
        Paid = 1,

        /// <summary>
        /// Отменен по желанию пассажира.
        /// </summary>
        /// <remarks>
        /// Пассажир передумал до того, как водитель поиехал по адресу.
        /// </remarks>
        CanceledDueToPassengerRequest = 2,

        /// <summary>
        /// Отменен из-за опоздания водителя.
        /// </summary>
        CanceledDueToDriverDelay = 3,

        /// <summary>
        /// Прерван по желанию пассажира.
        /// </summary>
        /// <remarks>
        /// Пассажир передумал после того, как водитель приехал по адресу.
        /// </remarks>
        AbortedDueToPassengerRequest = 4,

        /// <summary>
        /// Прерван из-за отсутствия пассажира.
        /// </summary>
        AbortedDueToPassengerLack = 5,

        /// <summary>
        /// Прерван из-за аварии в пути.
        /// </summary>
        AbortedDueToAccident = 6,

        /// <summary>
        /// Не оплачен.
        /// </summary>
        /// <remarks>
        /// Водитель довез пассажира до коечной точки маршрута, но получил не все деньги.
        /// </remarks>
        NoPaid = 7,
    }
}