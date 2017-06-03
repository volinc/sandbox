namespace EF6Test.Data
{
    using System;

    public class OrderData
    {
        public Guid Id { get; set; }

        public long DriverId { get; set; }

        public long State { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public virtual DriverData Driver { get; set; }
    }
}
