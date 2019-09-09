namespace SqlitePclLock
{
    using Taxys.Geometry;
    using System;

    public class OrderLocation : Position
    {
        public long? OrderId { get; }
        public int Index { get; }

        public OrderLocation(Location location, DateTimeOffset timestamp, double speed, double heading) : base(
            location, timestamp, speed, heading)
        {
        }

        public OrderLocation(Location location, DateTimeOffset timestamp, double speed, double heading, long orderId,
                             int index) : base(location, timestamp, speed, heading)
        {
            OrderId = orderId;
            Index = index;
        }
    }
}
