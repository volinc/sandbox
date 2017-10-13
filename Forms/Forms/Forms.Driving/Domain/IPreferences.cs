using System;

namespace Forms.Driving.Domain
{
    /// <summary>
    /// Описывает параметры устройства, программы и операционной системы.
    /// </summary>
    public interface IPreferences
    {
        /// <summary>
        /// Возвращает идентификатор приложения.
        /// </summary>
        /// <remarks>
        /// Уникальное значение, которое генерируется при первом запуске приложения.
        /// </remarks>
        Guid AppId { get; }

        /// <summary>
        /// Возвращает версию приложения, например, "1.3.7".
        /// </summary>
        string AppVersion { get; }

        /// <summary>
        /// Возвращает модель устройства, например, "VS Emulator 5-inch Marshmallow (6.0.0) XXHDPI Phone".
        /// </summary>
        string DeviceModel { get; }

        /// <summary>
        /// Возвращает тип операционной системы, например, "Android".
        /// </summary>
        string OsType { get; }

        /// <summary>
        /// Возвращает версию операционной системы, например, "6.0".
        /// </summary>
        string OsVersion { get; }
    }
}