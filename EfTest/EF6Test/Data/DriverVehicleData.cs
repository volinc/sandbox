using System;
using System.Collections.Generic;

namespace EF6Test.Data
{
    public class DriverVehicleData
    {
        public long DriverId { get; set; }

        public Guid VehicleId { get; set; }

        public virtual ICollection<long> Drivers { get; } = new HashSet<long>();

        public virtual ICollection<Guid> Vehicles { get; } = new HashSet<Guid>();
    }
}
