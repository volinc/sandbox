using System;

namespace Forms.Driving.Infrastructure
{
    public interface IWaiter : IDisposable
    {
        /// <summary>
        /// Событие возникающее по таймеру в течении ожидания (для автоматической проверки необходимости ожидания).
        /// </summary>
        event EventHandler<TimeSpan> Elapsed;

        /// <summary>
        /// Событие возникающее после остановки работы ожидания.
        /// </summary>
        event EventHandler Stopped;

        /// <summary>
        /// Возвращает значение признак работы ожидания.
        /// </summary>
        bool IsEnabled { get; }

        /// <summary>
        /// Возвращает интервал ожидания (время прошедшее с момента начала ожидания).
        /// </summary>
        TimeSpan WaitingFor { get; }

        /// <summary>
        /// Запускает ожидание.
        /// </summary>
        void Start();

        /// <summary>
        /// Запускает ожидание с узаканием уже прошедшего интервала ожидания.
        /// </summary>
        /// <param name="waitingFor">Интервал ожидания.</param>
        void Start(TimeSpan waitingFor);

        /// <summary>
        /// Останавливает ожидание.
        /// </summary>
        void Stop();
    }
}