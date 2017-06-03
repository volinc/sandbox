namespace EF6Test.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using EF6Test.Data;

    public class Search
    {
        private readonly SearchData data;

        private Search(SearchData data)
        {
            this.data = data;
        }

        public Guid Id => data.Id;

        public DateTimeOffset CreatedAt => data.CreatedAt;

        public DateTimeOffset ModifiedAt => data.ModifiedAt;

        public long State
        {
            get => data.State;
            set
            {
                data.State = value;
                data.ModifiedAt = DateTimeOffset.Now;
            }
        }

        public IReadOnlyCollection<Suggestion> Suggestions { get; private set; }

        public void AddSuggestion(decimal price)
        {
            var suggestion = new Suggestion(Id, price);
            data.Suggestions.Add(Suggestion.Map.To(suggestion));
            ((ICollection<Suggestion>)Suggestions).Add(suggestion);
            data.ModifiedAt = DateTimeOffset.Now;
        }

        public static class Map
        {
            public static Search From(SearchData data) => new Search(data)
            {                                                                                                                 
                Suggestions = data.Suggestions.Select(Suggestion.Map.From).ToList()
            };

            public static SearchData To(Search domain) => domain.data;
        }
    }
}
