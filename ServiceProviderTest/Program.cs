namespace ServiceProviderTest
{
    using Microsoft.Extensions.DependencyInjection;
    using System;

    internal class Program
    {
        private static void Main()
        {            
            var services = new ServiceCollection();
            services.AddScopeAccessor();

            services.AddSingleton(sp => sp.GetRequiredFunc<Book>())
                    .AddScoped<Book>();
                
            Run(services.BuildServiceProvider());                
            
            Console.ReadLine();
        }

        private static void Run(IServiceProvider serviceProvider)
        {            
            Console.WriteLine(serviceProvider.GetRequiredService<Book>());
            Console.WriteLine(serviceProvider.GetRequiredService<Func<Book>>()());

            using (var accessor = serviceProvider.CreateScopeAccessor())
                Console.WriteLine(accessor.ScopeServices.GetRequiredService<Func<Book>>()());            

            Console.WriteLine(serviceProvider.GetRequiredService<Func<Book>>()());
        }
    }

    public class Book
    {        
        public Book() { Number = Guid.NewGuid(); }
        
        public Guid Number { get; }

        public override string ToString() => $"Book {Number}";
    }
}
