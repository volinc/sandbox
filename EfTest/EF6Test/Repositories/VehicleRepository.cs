using EF6Test.Data;
using System;

namespace EF6Test.Repositories
{
    public class VehicleRepository
    {
        private readonly ApplicationDbContext dbContext;

        public VehicleRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Guid Create(string registrationNumber, string vin)
        {
            var vehicleData = dbContext.Vehicles.Add(new VehicleData
            {
                RegistrationNumber = registrationNumber,
                Vin = vin,
            });

            return vehicleData.Id;
        }
    }
}
