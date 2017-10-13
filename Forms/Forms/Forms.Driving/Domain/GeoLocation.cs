using System;

namespace Forms.Driving.Domain
{
    /// <summary>
    /// Описывает географическое местоположение.
    /// </summary>
    public class GeoLocation
    {
        /// <summary>
        /// Инициирует новый экземпляр типа <see cref="GeoLocation"/>.
        /// </summary>
        /// <param name="latitude">Широта.</param>
        /// <param name="longitude">Долгота.</param>
        /// <param name="accuracy">Точность.</param>
        /// <param name="timestamp">Отметка времени.</param>
        public GeoLocation(double latitude, double longitude, double accuracy, DateTimeOffset timestamp)
        {
            Latitude = latitude;
            Longitude = longitude;
            Accuracy = accuracy;
            Timestamp = timestamp;
        }

        /// <summary>
        /// Инициирует новый экземпляр типа <see cref="GeoLocation"/>.
        /// </summary>
        /// <param name="latitude">Широта.</param>
        /// <param name="longitude">Долгота.</param>
        public GeoLocation(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;                        
        }

        /// <summary>
        /// Широта.
        /// </summary>
        public double Latitude { get; }

        /// <summary>
        /// Долгота.
        /// </summary>
        public double Longitude { get; }

        /// <summary>
        /// Точность.
        /// </summary>
        public double Accuracy { get; }

        /// <summary>
        /// Отметка времени.
        /// </summary>
        public DateTimeOffset Timestamp { get; }        
    }
}