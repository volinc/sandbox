namespace SqlitePclLock
{
    using Newtonsoft.Json;
    using System;
    using Taxys.Geometry;

    public class OrderTrackPoint : TrackPoint
    {
        public int Index { get; }
        
        [JsonConstructor]
        public OrderTrackPoint(int index, DateTimeOffset timestamp, Location location) 
            : this(index, timestamp, location, 0, 0)
        {                        
        }
        
        public OrderTrackPoint(int index, DateTimeOffset timestamp, Location location, double speed, double heading) 
            : base(location, timestamp, speed, heading)
        {
            Index = index;            
        }
    }
}
