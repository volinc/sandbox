namespace Forms.Driving.Domain
{
    public enum LocationError
    {
        /// <summary>
        /// Позиция неопределена.
        /// </summary>
        PositionUnavailable = 0,

        /// <summary>
        /// Неавторизованы.
        /// </summary>
        Unauthorized = 1,
    }
}