namespace EF6Test.Data
{
    using System;

    public class SuggestionData
    {
        public Guid Id { get; set; }

        public Guid OrderId { get; set; }

        public Guid ShiftId { get; set; }

        public decimal Price { get; set; }

        public long State { get; set; }    
        
        public virtual OrderData Order { get; set; }

        public virtual ShiftData Shift { get; set; }
    }
}
