namespace MessagePackTest
{
    using MessagePack;
    using MessagePack.Resolvers;
    using System;

    internal class Program
    {
        private static void Main()
        {
            var book = Book.Create("abc");
            var bytes = MessagePackSerializer.Serialize(book, ContractlessStandardResolver.Instance);
            book = MessagePackSerializer.Deserialize<Book>(bytes, ContractlessStandardResolver.Instance);
            Console.WriteLine(book.Author);
        }
    }

    public class Book
    {
        public Book(string author)
        {
            Author = author;
        }

        public string Author { get; }

        public static Book Create(string author)
        {
            return new Book(author);
        }
    }
}
