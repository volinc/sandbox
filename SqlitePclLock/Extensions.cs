namespace SqlitePclLock
{
    using Taxys.Geometry;

    public static class Extensions
    {
        public static OrderTrackPoint ToOrderTrackPoint(this OrderLocationSqLite source)
        {
            if (source == null)
                return null;

            var location = new Location(source.Latitude, source.Longitude);

            return new OrderTrackPoint(source.Index, source.Timestamp, location, source.Speed, source.Heading);
        }

        public static OrderLocation ToOrderLocation(this OrderLocationSqLite source)
        {
            if (source == null)
                return null;

            var location = new Location(source.Latitude, source.Longitude);

            return new OrderLocation(location, source.Timestamp, source.Speed, source.Heading, source.OrderId, source.Index);
        }
    }
}
