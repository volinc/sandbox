using System;

namespace Forms.Driving.Infrastructure
{
    /// <summary>
    /// Описывает интерфейс журнала событий программы.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Записывает трассирующее событие.
        /// </summary>
        /// <param name="message">Текст сообщения.</param>
        void Trace(string message);

        /// <summary>
        /// Записывает трассирующее событие и сопровождающие данные.
        /// </summary>
        /// <param name="message">Текст сообщения.</param>
        /// <param name="data">Данные.</param>
        void Trace(string message, object data);

        /// <summary>
        /// Записывает отладочное событие.
        /// </summary>
        /// <param name="message">Текст сообщения.</param>
        void Debug(string message);

        /// <summary>
        /// Записывает отладочное событие и сопровождающие данные.
        /// </summary>
        /// <param name="message">Текст сообщения.</param>
        /// <param name="data">Данные.</param>
        void Debug(string message, object data);

        /// <summary>
        /// Записывает информационное событие.
        /// </summary>
        /// <param name="message">Текст сообщения.</param>
        void Info(string message);

        /// <summary>
        /// Записывает информационное событие и сопровождающие данные.
        /// </summary>
        /// <param name="message">Текст сообщения.</param>
        /// <param name="data">Данные.</param>
        void Info(string message, object data);

        /// <summary>
        /// Записывает предупреждающее событие.
        /// </summary>
        /// <param name="message">Текст сообщения.</param>
        void Warning(string message);

        /// <summary>
        /// Записывает предупреждающее событие, вызванное исключением.
        /// </summary>
        /// <param name="exception">Исключение.</param>
        void Warning(Exception exception);

        /// <summary>
        /// Записывает предупреждающее событие и сопровождающие данные.
        /// </summary>
        /// <param name="message">Текст сообщения.</param>
        /// <param name="data">Данные.</param>
        void Warning(string message, object data);

        /// <summary>
        /// Записывает ошибочное событие.
        /// </summary>
        /// <param name="message">Текст сообщения.</param>
        void Error(string message);

        /// <summary>
        /// Записывает ошибочное событие, вызванное исключением.
        /// </summary>
        /// <param name="exception">Исключение.</param>
        void Error(Exception exception);

        /// <summary>
        /// Записывает ошибочное событие и сопровождающие данные.
        /// </summary>
        /// <param name="message">Текст сообщения.</param>
        /// <param name="data">Данные.</param>
        void Error(string message, object data);

        /// <summary>
        /// Записывает фатальное событие.
        /// </summary>
        /// <param name="message">Текст сообщения.</param>
        void Fatal(string message);

        /// <summary>
        /// Записывает фатальное событие, вызванное исключением.
        /// </summary>
        /// <param name="exception">Исключение.</param>
        void Fatal(Exception exception);

        /// <summary>
        /// Записывает фатальное событие и сопровождающие данные.
        /// </summary>
        /// <param name="message">Текст сообщения.</param>
        /// <param name="data">Данные.</param>
        void Fatal(string message, object data);
    }
}