using System;

namespace EF6Test.Domain
{
    using EF6Test.Data;

    public class Suggestion
    {
        private readonly SuggestionData data;

        private Suggestion(SuggestionData data)
        {
            this.data = data;
        }

        internal Suggestion(Guid searchId, decimal price)
        {
            data = new SuggestionData
            {
                SearchId = searchId,
                Price = price,
                State = 1,
            };
        }

        public Guid Id => data.Id;

        public Guid SearchId => data.SearchId;

        public decimal Price => data.Price;

        public long State
        {
            get => data.State;
            set => data.State = value;
        }

        public static class Map
        {
            public static Suggestion From(SuggestionData data) => new Suggestion(data);

            public static SuggestionData To(Suggestion domain) => domain.data;
        }        
    }
}
