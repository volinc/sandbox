namespace EF6Test.Repositories
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using EF6Test.Data;
    using EF6Test.Domain;

    public class SearchRepository
    {
        private readonly ApplicationDbContext dbContext;

        public SearchRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Search Create(OrderState state)
        {
            var now = DateTimeOffset.Now;

            var data = dbContext.Orders.Add(new OrderData
            {
                State = state,
                ModifiedAt = now,
                CreatedAt = now,
            });

            dbContext.SaveChanges();

            return Search.Map.From(data);
        }

        public Search Read(Guid searchId)
        {
            var data = dbContext.Orders.Local.SingleOrDefault(x => x.Id == searchId) ??
                       dbContext.Orders.Include(x => x.Suggestions).Single(x => x.Id == searchId);

            return Search.Map.From(data);
        }

        public void Update(Search domain)
        {
            try
            {
                dbContext.Configuration.AutoDetectChangesEnabled = false;

                var newSearch = Search.Map.To(domain);
                var oldSearch = dbContext.Orders.Find(newSearch.Id);
                dbContext.Entry(oldSearch).CurrentValues.SetValues(newSearch);

                foreach (var newSuggestion in newSearch.Suggestions)
                {
                    if (newSuggestion.Id != Guid.Empty)
                    {
                        var oldSuggestion = dbContext.Suggestions.Find(newSuggestion.Id);
                        dbContext.Entry(oldSuggestion).CurrentValues.SetValues(newSuggestion);
                    }
                    else
                        dbContext.Entry(newSuggestion).State = EntityState.Added;
                }

                dbContext.ChangeTracker.DetectChanges();
                dbContext.SaveChanges();
            }
            finally
            {
                dbContext.Configuration.AutoDetectChangesEnabled = true;
            }
        }
    }
}
