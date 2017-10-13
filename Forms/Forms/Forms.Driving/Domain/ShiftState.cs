namespace Forms.Driving.Domain
{
    /// <summary>
    /// Перечисляет состояния рабочей смены.
    /// </summary>
    public enum ShiftState
    {
        /// <summary>
        /// Перерыв.
        /// </summary>
        /// <remarks>Смена временно не готова принимать заказы.</remarks>
        Paused = 1,

        /// <summary>
        /// Доступность.
        /// </summary>
        /// <remarks>Смена готова принимать заказы.</remarks>
        Available = 2,

        /// <summary>
        /// Занятость.
        /// </summary>
        /// <remarks>Смена выполняет заказ.</remarks>
        Busy = 3,

        /// <summary>
        /// Закрыта.
        /// </summary>
        Closed = 4,
    }
}