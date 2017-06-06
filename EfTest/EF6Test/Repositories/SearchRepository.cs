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
                var data = ctx.Searches.Local.SingleOrDefault(x => x.Id == searchId);
                if (data == null)
                {
                    data = ctx.Searches.AsNoTracking().Include(x => x.Suggestions).Single(x => x.Id == searchId);
                }

                return Search.Map.From(data);
            }
        }

        public void Update(Search domain)
        {
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Configuration.AutoDetectChangesEnabled = false;

                var newSearch = Search.Map.To(domain);
                var oldSearch = ctx.Searches.Find(newSearch.Id);
                ctx.Entry(oldSearch).CurrentValues.SetValues(newSearch);

                foreach (var newSuggestion in newSearch.Suggestions)
                {
                    if (newSuggestion.Id != Guid.Empty)
                    {
                        var oldSuggestion = ctx.Suggestions.Find(newSuggestion.Id);
                        ctx.Entry(oldSuggestion).CurrentValues.SetValues(newSuggestion);
                    }
                    else
                        ctx.Entry(newSuggestion).State = EntityState.Added;
                }

                ctx.ChangeTracker.DetectChanges();
                ctx.SaveChanges();
            }
        }
    }
}
