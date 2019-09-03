namespace SqlitePclLock
{
    using System;

    public class OrderLocation : Position
    {
        public OrderLocation(Taxys.Geometry.Location location, DateTimeOffset timestamp, double speed, double heading) : base(
            location, timestamp, speed, heading)
        {
        }

        public OrderLocation(Taxys.Geometry.Location location, DateTimeOffset timestamp, double speed, double heading, long orderId,
                             int index) : base(location, timestamp, speed, heading)
        {
            OrderId = orderId;
            Index = index;
        }

        public long? OrderId  { get; }
        public int? Index  { get; }
    }
}
