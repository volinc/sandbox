namespace ServiceProviderTest
{    
    using Microsoft.Extensions.DependencyInjection;
    using System;
    
    internal class Program
    {
        private static void Main()
        {            
            var services = new ServiceCollection();
            services.AddScoped<Book>();
            services.AddSingleton<Func<Book>>(sp => sp.GetRequiredService<Book>);                                
            var serviceProvider = services.BuildServiceProvider();

            Run(serviceProvider);
            Console.ReadLine();
        }

        private static void Run(IServiceProvider serviceProvider)
        {
            var book = serviceProvider.GetRequiredService<Book>();            
            Console.WriteLine(book);

            var bookFactory = serviceProvider.GetRequiredService<Func<Book>>();
            var book0 = bookFactory();
            Console.WriteLine(book0);

            using var scope1 = serviceProvider.CreateScope();
            var bookFactory1 = scope1.ServiceProvider.GetRequiredService<Func<Book>>();
            var book1 = bookFactory();
            Console.WriteLine(book1);
        }
    }

    public class Book
    {        
        public Book() { Number = Guid.NewGuid(); }
        
        public Guid Number { get; }

        public override string ToString() => $"Book {Number}";
    }
}
