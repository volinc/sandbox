namespace EF6Test.Data
{
    using System;

    public class SuggestionData
    {
        public Guid Id { get; set; }

        public Guid SearchId { get; set; }

        public decimal Price { get; set; }

        public long State { get; set; }    
        
        public virtual SearchData Search { get; set; }
    }
}
