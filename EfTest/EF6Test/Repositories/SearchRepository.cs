namespace EF6Test.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using EF6Test.Data;
    using EF6Test.Domain;

    public class SearchRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly Func<DateTimeOffset> now;

        public SearchRepository(ApplicationDbContext dbContext, Func<DateTimeOffset> now)
        {
            this.dbContext = dbContext;
            this.now = now;
        }

        public Search Create(long passengerId, OrderState state, ICollection<Suggestion> suggestions = null,
            Guid? companyId = null)
        {
            if (!(state == OrderState.Searching && suggestions != null ||
                  state == OrderState.Created && suggestions == null))
                throw new InvalidOperationException();

            var currentTime = now();

            var orderData = new OrderData
            {
                PassengerId = passengerId,
                State = OrderState.Searching,
                ModifiedAt = currentTime,
                CreatedAt = currentTime,
            };

            if (suggestions != null && suggestions.Any())
            {
                foreach (var suggestion in suggestions)
                {
                    var suggestionData = Suggestion.Map.To(suggestion);
                    orderData.Suggestions.Add(suggestionData);
                }
            }

            if (companyId.HasValue)
            {
                orderData.AggregatorOrder = new AggregatorOrderData
                {
                    CompanyId = companyId.Value,
                };
            }

            orderData = dbContext.Orders.Add(orderData);

            dbContext.SaveChanges();

            return Search.Map.From(orderData);
        }

        public Search Read(Guid searchId)
        {
            var data = dbContext.Orders.Local.SingleOrDefault(x => x.Id == searchId) ??
                       dbContext.Orders.Include(x => x.AggregatorOrder).Include(x => x.Suggestions)
                           .Single(x => x.Id == searchId);

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
