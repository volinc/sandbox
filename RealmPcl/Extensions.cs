using Taxys.Geometry;

namespace SqlitePclLock
{
    public static class Extensions
    {
        public static OrderTrackPoint ToOrderTrackPoint(this OrderLocationRealm source)
        {
            if (source == null)
                return null;

            var location = new Location(source.Latitude, source.Longitude);

            return new OrderTrackPoint(source.Index, source.Timestamp, location, source.Speed, source.Heading);
        }

        public static OrderLocation ToOrderLocation(this OrderLocationRealm source)
        {
            if (source == null)
                return null;

            var location = new Location(source.Latitude, source.Longitude);

            return new OrderLocation(location, source.Timestamp, source.Speed, source.Heading, source.OrderId, source.Index);
        }
    }
}
