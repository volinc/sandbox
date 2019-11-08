using System.Threading.Tasks;

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

            services.AddScoped<Book>()
                    .AddScoped(sp => sp.GetRequiredFunc<Book>())
                    .AddSingleton<BookService>();
                
            Run(services.BuildServiceProvider());
            
            Console.ReadLine();
        }

        private static void Run(IServiceProvider serviceProvider)
        {
            Console.WriteLine("{0} root", serviceProvider.GetRequiredService<Book>());
            Console.WriteLine("{0} root func", serviceProvider.GetRequiredService<Func<Book>>()());
            Console.WriteLine("{0} service func", serviceProvider.GetRequiredService<BookService>().Create());

            Task.Run(async () =>
            {
                Console.WriteLine("1 {0} root", serviceProvider.GetRequiredService<Book>());
                using var scope1 = serviceProvider.CreateContextScope();
                Console.WriteLine("1 {0} {1} func", scope1.ServiceProvider.GetRequiredService<Func<Book>>()(), nameof(scope1));
                Console.WriteLine("1 {0} {1} service func", scope1.ServiceProvider.GetRequiredService<BookService>().Create(), nameof(scope1));

                Console.WriteLine(await scope1.ServiceProvider.GetRequiredService<BookService>().CreateAsync());
            });
        }

        //private static void NewMethod(ContextScope scope1)
        //{
        //    Console.WriteLine("1 {0} {1} func", scope1.ServiceProvider.GetRequiredService<Func<Book>>()(), nameof(scope1));
        //    Console.WriteLine("1 {0} {1} service func", scope1.ServiceProvider.GetRequiredService<BookService>().Create(),
        //        nameof(scope1));
        //    Console.WriteLine("1 {0} {1} service func", scope1.ServiceProvider.GetRequiredService<BookService>().Create(),
        //        nameof(scope1));

        //    //Console.WriteLine("2 {0} root", serviceProvider.GetRequiredService<Book>());
        //    //using var scope2 = serviceProvider.CreateContextScope();
        //    //Console.WriteLine("2 {0} {1} func", scope2.ServiceProvider.GetRequiredService<Func<Book>>()(), nameof(scope2));
        //    //Console.WriteLine("2 {0} {1} service func", scope2.ServiceProvider.GetRequiredService<BookService>().Create(), nameof(scope2));
        //    //Console.WriteLine("2 {0} {1} service func", scope2.ServiceProvider.GetRequiredService<BookService>().Create(), nameof(scope2));
        //}
    }
}
