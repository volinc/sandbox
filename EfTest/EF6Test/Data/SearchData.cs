using System;

namespace EF6Test.Data
{
    using System.Collections.Generic;

    public class SearchData
    {
        public Guid Id { get; set; }

        public long State { get; set; }

        public DateTimeOffset ModifiedAt { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public virtual ICollection<SuggestionData> Suggestions { get; } = new HashSet<SuggestionData>();
    }
}
