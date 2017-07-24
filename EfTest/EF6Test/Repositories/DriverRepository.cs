using EF6Test.Data;

namespace EF6Test.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DriverRepository
    {
        private readonly ApplicationDbContext dbContext;

        public DriverRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(long personId, string givenName, string familyName, string licenseNumber,
            int? experienceFrom = null, ICollection<Guid> vehicleIds = null)
        {
            dbContext.Drivers.Add(new DriverData
            {                
                ExperienceFrom = experienceFrom,
                LicenseNumber = licenseNumber,
                Person = new PersonData
                {
                    Id = personId,
                    GivenNames = givenName,
                    FamilyName = familyName,
                }
            });

            if (vehicleIds != null && vehicleIds.Any())
            {
                var badVehicleIds = dbContext.Vehicles.AsNoTracking()
                    .Where(x => !vehicleIds.Contains(x.Id))
                    .Select(x => x.Id)
                    .AsEnumerable();

                if (badVehicleIds.Any())
                    throw new InvalidOperationException();

                var driverVehicles = vehicleIds.Distinct().Select(x => new DriverVehicleData
                {
                    DriverId = personId,
                    VehicleId = x
                });

                dbContext.DriverVehicles.AddRange(driverVehicles);
            }            

            dbContext.SaveChanges();
        }
    }
}
