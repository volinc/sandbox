namespace EF6Test.Repositories
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using EF6Test.Data;
    using EF6Test.Domain;

    public class SearchRepository
    {
        private readonly IDbContextFactory<ApplicationDbContext> dbContextFactory;

        public SearchRepository(IDbContextFactory<ApplicationDbContext> dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }

        public Search Create(long state)
        {
            var ctx = dbContextFactory.Create();

            var now = DateTimeOffset.Now;

            var data = ctx.Searches.Add(new SearchData
            {
                State = state,
                ModifiedAt = now,
                CreatedAt = now,                    
            });

            ctx.SaveChanges();

            return Search.Map.From(data);            
        }

        public Search Read(Guid searchId)
        {
            var ctx = dbContextFactory.Create();

            var data = ctx.Searches.AsNoTracking().Include(x => x.Suggestions).Single(x => x.Id == searchId);

            return Search.Map.From(data);            
        }

        public void Update(Search domain)
        {
            var ctx = dbContextFactory.Create();

            var data = Search.Map.To(domain);
              
            foreach (var suggestionData in data.Suggestions)
                ctx.Suggestions.AddOrUpdate(suggestionData);

            ctx.ChangeTracker.DetectChanges();

            ctx.SaveChanges();            
        }
    }
}
