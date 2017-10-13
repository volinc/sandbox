using System;
using Forms.Driving.Data;

namespace Forms.Driving.Domain.Entities
{
    public class Offer
    {
        private readonly NewOfferData data;

        private Offer(NewOfferData data, PriceDescription price)
        {
            this.data = data;

            Price = price;
            ReceivedAt = DateTimeOffset.Now;            
        }

        public long SuggestionId => data.SuggestionId;

        public Place Start => data.Start;

        public Place End => data.End;

        public TimeSpan ArrivalTime => data.ArrivalTime;

        public DateTimeOffset CreatedAt => data.CreatedAt;

        public DateTimeOffset? DepartedAt => data.DepartedAt;

        public PriceDescription Price { get; }

        public TimeSpan Lifetime => data.Lifetime;

        public DateTimeOffset ReceivedAt { get; }

        public string Comment => data.OrderComment;

        public static class Map
        {
            public static Offer From(NewOfferData data) =>
                data == null ? null : new Offer(data, PriceDescription.Map.From(data.Price));
        }
    }
}
