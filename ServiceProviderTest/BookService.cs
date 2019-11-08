using System;
using System.Threading.Tasks;

namespace ServiceProviderTest
{
    public class BookService
    {
        private readonly Func<Book> bookFactory;

        public BookService(Func<Book> bookFactory) => this.bookFactory = bookFactory;

        public Book Create() => bookFactory();

        public Task<Book> CreateAsync() => Task.Run(() => bookFactory());
    }
}