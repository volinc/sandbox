namespace Forms.Driving.Domain
{
    /// <summary>
    /// Описывает стадию работы водителя.
    /// </summary>
    public enum ProcessState
    {
        /// <summary>
        /// Водитель ждет обновления состояния с сервера.
        /// </summary>
        Update,

        /// <summary>
        /// Водитель запустил приложение и собирается войти в систему.
        /// </summary>
        Login,

        /// <summary>
        /// Водитель вошел в систему и должен выбрать машину, чтобы начать смену.
        /// </summary>
        Garage,

        /// <summary>
        /// Водитель начал смену и ожидает заказов либо отдыхает.
        /// </summary>
        Shift,

        /// <summary>
        /// Водитель получил предложение о заказе.
        /// </summary>
        Offer,

        /// <summary>
        /// Водитель получил заказ и выполняет его.
        /// </summary>
        Order,
    }
}