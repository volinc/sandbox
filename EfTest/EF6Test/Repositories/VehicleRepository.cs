using EF6Test.Data;
using System;

namespace EF6Test.Repositories
{
    using System.Collections.Generic;
    using System.Linq;

    public class VehicleRepository
    {
        private readonly ApplicationDbContext dbContext;

        public VehicleRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Guid Create(string registrationNumber, string vin, ICollection<long> driverIds = null)
        {
            var vehicleData = dbContext.Vehicles.Add(new VehicleData
            {
                RegistrationNumber = registrationNumber,
                Vin = vin,
            });

            dbContext.SaveChanges();

            if (driverIds != null && driverIds.Any())
            {
                var badDriverIds = dbContext.Drivers.AsNoTracking()
                    .Where(x => !driverIds.Contains(x.Id))
                    .Select(x => x.Id)
                    .AsEnumerable();

                if (badDriverIds.Any())
                    throw new InvalidOperationException();

                var driverVehicles = driverIds.Distinct().Select(x => new DriverVehicleData
                {
                    DriverId = x,
                    VehicleId = vehicleData.Id,
                });

                foreach (var data in driverVehicles)
                    vehicleData.DriverVehicles.Add(data);
            }

            dbContext.SaveChanges();

            return vehicleData.Id;
        }
    }
}
