using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace SignalR.Client
{
    public class OfferRepository
    {
        private readonly DbContextOptions<AppDbContext> options;

        public OfferRepository()
        {
            options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "testdb")
                .Options;
        }

        public void Create(Offer offer)
        {
            using (var context = new AppDbContext(options))
            {
                context.Offers.Add(offer);                
                context.SaveChanges();
            }
        }

        public Offer Read(string offerId)
        {
            using (var context = new AppDbContext(options))
            {
                return context.Offers.SingleOrDefault(x => x.Id == offerId);                
            }
        }

        public IEnumerable<Offer> ReadAll()
        {
            using (var context = new AppDbContext(options))
            {
                return context.Offers.ToList();
            }
        }
    }
}
