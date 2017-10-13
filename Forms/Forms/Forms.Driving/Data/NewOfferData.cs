using System;

namespace Forms.Driving.Data
{
    public class NewOfferData
    {
        public long SuggestionId { get; set; }

        public Place Start { get; set; }

        public Place End { get; set; }

        public TimeSpan ArrivalTime { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset? DepartedAt { get; set; }

        public PriceDescriptionData Price { get; set; }

        public TimeSpan Lifetime { get; set; }

        public string OrderComment { get; set; }
    }
}
