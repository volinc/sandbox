using System.Collections.Generic;

namespace Forms.Driving.Data
{
    public class JsonArray<T>
    {
        public IReadOnlyCollection<T> Items { get; set; }
    }
}