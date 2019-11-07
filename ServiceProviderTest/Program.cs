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

            services.AddScoped(sp => sp.GetRequiredFunc<Book>())
                    .AddScoped<Book>();
                
            Run(services.BuildServiceProvider());                
            
            Console.ReadLine();
        }

        private static void Run(IServiceProvider serviceProvider)
        {            
            Console.WriteLine("root\t\t\t\t\t{0}", serviceProvider.GetRequiredService<Book>());
            Console.WriteLine("root func\t\t\t\t{0}", serviceProvider.GetRequiredService<Func<Book>>()());

            using (var accessor0 = serviceProvider.CreateScopeAccessor())
            {
                Console.WriteLine($"{nameof(accessor0)} {accessor0.Id}\t{accessor0.ScopeServices.GetRequiredService<Func<Book>>()()}");

                using (var accessor1 = serviceProvider.CreateScopeAccessor())
                {
                    Console.WriteLine($"{nameof(accessor1)} {accessor1.Id}\t\t{accessor1.ScopeServices.GetRequiredService<Func<Book>>()()}");
                }

                Console.WriteLine($"{nameof(accessor0)} {accessor0.Id}\t{accessor0.ScopeServices.GetRequiredService<Func<Book>>()()}");
            }

            using (var accessor2 = serviceProvider.CreateScopeAccessor())
            {
                Console.WriteLine($"{nameof(accessor2)} {accessor2.Id}\t{accessor2.ScopeServices.GetRequiredService<Func<Book>>()()}");
            }

            Console.WriteLine("root func\t\t\t\t{0}", serviceProvider.GetRequiredService<Func<Book>>()());
        }
    }
}
