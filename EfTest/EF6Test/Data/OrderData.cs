using System;

namespace EF6Test.Data
{
    using EF6Test.Domain;
    using System.Collections.Generic;

    public class OrderData
    {
        public Guid Id { get; set; }

        public long PassengerId { get; set; }

        public OrderState State { get; set; }

        public DateTimeOffset ModifiedAt { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public Guid? ShiftId { get; set; }

        public virtual AggregatorOrderData AggregatorOrder { get; set; }

        public virtual PassengerData Passenger { get; set; }

        public virtual ShiftData Shift { get; set; }

        public virtual ICollection<SuggestionData> Suggestions { get; } = new HashSet<SuggestionData>();        
    }
}
