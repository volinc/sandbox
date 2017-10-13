using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Forms.Driving.Data
{
    public class ConditionalValue<T>
    {
        public static readonly ConditionalValue<T> None = new ConditionalValue<T>(false, default(T));

        public ConditionalValue(T value)
        {
            HasValue = true;
            Value = value;
        }

        [JsonConstructor]
        protected ConditionalValue(bool hasValue, T value)
        {
            HasValue = hasValue;
            Value = value;
        }

        public bool HasValue { get; }
        public T Value { get; }        
    }
}
