using EF6Test.Data;

namespace EF6Test.Repositories
{
    public class DriverRepository
    {
        private readonly ApplicationDbContext dbContext;

        public DriverRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(long personId, string givenName, string familyName, string licenseNumber, int? experienceFrom = null)
        {
            var data = dbContext.Drivers.Add(new DriverData
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

            dbContext.SaveChanges();
        }
    }
}
