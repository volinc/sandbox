namespace EF6Test.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using EF6Test.Data;

    public class Search
    {
        private readonly OrderData data;

        private Search(OrderData data)
        {
            this.data = data;
        }

        public Guid Id => data.Id;

        public DateTimeOffset CreatedAt => data.CreatedAt;

        public DateTimeOffset ModifiedAt => data.ModifiedAt;

        public OrderState State
        {
            get => data.State;
            private set
            {
                data.State = value;
                data.ModifiedAt = DateTimeOffset.Now;
            }
        }

        public IReadOnlyCollection<Suggestion> Suggestions { get; private set; }

        public void AddSuggestion(decimal price)
        {
            if (State != OrderState.Scheduled)
                throw new InvalidOperationException();

            var suggestion = new Suggestion(Id, price);
            data.Suggestions.Add(Suggestion.Map.To(suggestion));
            ((ICollection<Suggestion>)Suggestions).Add(suggestion);
            data.State = OrderState.Searching;                      
        }

        public static class Map
        {
            public static Search From(OrderData data) => new Search(data)
            {                                                                                                                 
                Suggestions = data.Suggestions.Select(Suggestion.Map.From).ToList()
            };

            public static OrderData To(Search domain) => domain.data;
        }
    }
}
