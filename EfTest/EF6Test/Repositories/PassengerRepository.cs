using System;

namespace EF6Test.Repositories
{
    using EF6Test.Data;

    public class PassengerRepository
    {
        private readonly ApplicationDbContext dbContext;

        public PassengerRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(long personId, string givenName, string familyName, DateTimeOffset? birthDate = null)
        {
            dbContext.Passengers.Add(new PassengerData
            {
                BirthDate = birthDate, 
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
