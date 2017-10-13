using System;
using System.Linq;
using Forms.Driving.Data;

namespace Forms.Driving.Infrastructure
{
    /// <summary>
    /// Исключение, которое выдается, если в результате обработки запроса произашла ошибка.
    /// </summary>
    /// <remarks>
    /// Соответствует статус коду HTTP 400 Bad Request.
    /// </remarks>
    public class ErrorResponseException : Exception
    {
        /// <summary>
        /// Возвращает контент ошибки.
        /// </summary>
        public HttpErrorResponseContentData ContentData { get; }

        /// <summary>
        /// Инициализирует новый экземпляр типа <see cref="ErrorResponseException"/> с указанным сообщением.
        /// </summary>
        public ErrorResponseException(HttpErrorResponseContentData contentData)
        {
            ContentData = contentData;
        }

        public override string Message
        {
            get
            {
                var titles = ContentData.Errors.Select(x => x.Title);

                return string.Join(Environment.NewLine, titles);
            }
        }
    }
}