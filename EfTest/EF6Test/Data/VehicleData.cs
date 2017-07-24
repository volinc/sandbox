using System;

namespace EF6Test.Data
{
    using System.Collections.Generic;

    public class VehicleData
    {
        public Guid Id { get; set; }

        public string RegistrationNumber { get; set; }

        public string Vin { get; set; }

        public virtual ICollection<DriverVehicleData> DriverVehicles { get; } = new HashSet<DriverVehicleData>();
    }
}
