namespace SqlitePclLock
{
    using Realms;
    using System;

    public class OrderLocationRealm : RealmObject
    {
        [PrimaryKey]
        public int Index { get; set; }
        
        [Indexed]
        public long OrderId { get; set; }

        public DateTimeOffset Timestamp { get; set; }
        
        public double Latitude { get; set; }
        
        public double Longitude { get; set; }

        public double Speed { get; set; }
        
        public double Heading { get; set; }

        public RealmInteger<int> Counter { get; set; }

    }
}
