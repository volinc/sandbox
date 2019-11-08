namespace ServiceProviderTest
{
    using System;

    public class Book
    {
        public Guid Number { get; } = Guid.NewGuid();

        public override string ToString() => $"Book {Number}";
    }
}
