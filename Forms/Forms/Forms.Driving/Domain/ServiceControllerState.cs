using Forms.Driving.Domain.Entities;

namespace Forms.Driving.Domain
{
    /// <summary>
    /// Хранит состояние фонового сервиса.
    /// </summary>
    public class ServiceControllerState
    {
        /// <summary>
        /// Возвращает стадию рабочего процесса, в которой находится фоновый сервис.
        /// </summary>
        public ProcessState ProcessState { get; }

        /// <summary>
        /// Возвращает финансовую информацию, или <c>null</c>, если она недоступна.
        /// </summary>
        public Finance FinanceOrNull { get; }

        /// <summary>
        /// Возвращает смену, или <c>null</c>, если она недоступна.
        /// </summary>
        public Shift ShiftOrNull { get; }

        /// <summary>
        /// Возвращает оффер, или <c>null</c>, если он недоступна.
        /// </summary>
        public Offer OfferOrNull { get; }

        /// <summary>
        /// Возвращает заказ, или <c>null</c>, если он недоступна.
        /// </summary>
        public Order OrderOrNull { get; }

        /// <summary>
        /// Инициализирует новый экземпляр типа <see cref="ServiceControllerState"/>.
        /// </summary>
        public ServiceControllerState(ProcessState processState,
                                      Finance financeOrNull,
                                      Shift shiftOrNull,
                                      Offer offerOrNull,
                                      Order orderOrNull)
        {
            ProcessState = processState;
            FinanceOrNull = financeOrNull;
            ShiftOrNull = shiftOrNull;
            OfferOrNull = offerOrNull;
            OrderOrNull = orderOrNull;
        }
    }
}
