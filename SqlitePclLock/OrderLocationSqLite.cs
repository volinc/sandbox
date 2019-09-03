namespace SqlitePclLock
{
    using SQLite;
    using System;

    [Table("OrderLocation")]
    public class OrderLocationSqLite
    {
        [PrimaryKey, AutoIncrement]
        public int Index { get; set; }
        
        public long OrderId { get; set; }

        [Unique]
        public DateTimeOffset Timestamp { get; set; }
        
        public double Latitude { get; set; }
        
        public double Longitude { get; set; }

        public double Speed { get; set; }
        
        public double Heading { get; set; }
    }
}
