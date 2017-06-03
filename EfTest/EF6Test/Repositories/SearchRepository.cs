namespace EF6Test.Repositories
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using EF6Test.Data;
    using EF6Test.Domain;

    public class SearchRepository
    {
        public Search Create(long state)
        {
            using (var ctx = new ApplicationDbContext())
            {
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
        }

        public Search Read(Guid searchId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var data = ctx.Searches.AsNoTracking().Include(x => x.Suggestions).Single(x => x.Id == searchId);

                return Search.Map.From(data);
            }
        }

        public void Update(Search domain)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var data = Search.Map.To(domain);
              
                foreach (var suggestionData in data.Suggestions)
                    ctx.Suggestions.AddOrUpdate(suggestionData);

                ctx.ChangeTracker.DetectChanges();

                ctx.SaveChanges();
            }
        }
    }
}
