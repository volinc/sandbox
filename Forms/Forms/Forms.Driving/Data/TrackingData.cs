using System;

namespace Forms.Driving.Data
{
    public class TrackingData
    {
        public long? OrderId { get; set; }

        public long? Index { get; set; }

        public Location Location { get; set; }

        public DateTimeOffset Timestamp { get; set; }
    }
}
