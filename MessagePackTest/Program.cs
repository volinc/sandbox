namespace MessagePackTest
{
    using MessagePack;
    using MessagePack.Formatters;
    using MessagePack.Resolvers;
    using System;

    internal class Program
    {
        private static void Main()
        {
            var book = Book.Create(BookState.None, "abc", 1);
            var bytes = MessagePackSerializer.Serialize(book, ContractlessStandardResolverAllowPrivate.Instance);
            book = MessagePackSerializer.Deserialize<Book>(bytes, ContractlessStandardResolver.Instance);
            Console.WriteLine(book);
        }
    }
    
    public enum BookState
    {
        None = 0,
        Published = 10
    }

    public class Book
    {
        public static readonly Book Complete = new Book(BookState.Published, "abc", 1);
        public static readonly Book New = new Book(BookState.None, "cba", 1);

        private Book(BookState state, string author, int count)
        {
            State = state;
            Author = author;
            Count = count;
        }

        public BookState State { get; }

        public string Author { get; }

        public int Count { get; }

        public static Book Create(BookState state, string author, int count) => new Book(state, author, count);

        public override string ToString() => $"{State} {Author}";
    }
}
