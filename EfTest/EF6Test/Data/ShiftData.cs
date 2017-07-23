using EF6Test.Domain;
using System;

namespace EF6Test.Data
{
    public class ShiftData
    {
        public Guid Id { get; set; }

        public Guid VehicleId { get; set; }

        public long DriverId { get; set; }

        public ShiftState State { get; set; }

        public DateTimeOffset OpenedAt { get; set; }

        public DateTimeOffset? ClosedAt { get; set; }

        public virtual VehicleData Vehicle { get; set; }

        public virtual DriverData Driver { get; set; }
    }
}
