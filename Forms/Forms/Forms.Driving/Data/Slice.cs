using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Forms.Driving.Data
{
    public class Slice<T>
    {
        [JsonConstructor]
        public Slice(IEnumerable<T> items, long totalCount)
        {
            Items = items.ToArray();
            TotalCount = totalCount;
        }

        public IReadOnlyCollection<T> Items { get; }

        public long TotalCount { get; }
    }
}
