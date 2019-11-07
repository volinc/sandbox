namespace AutofacTest
{
    using Autofac;
    using System;

    internal class Program
    {
        private static void Main()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.Register<Func<Book>>(c => c.Resolve<Book>);
            containerBuilder.RegisterType<Book>()
                            .InstancePerLifetimeScope();

            Run(containerBuilder.Build());

            Console.ReadLine();
        }

        private static void Run(IContainer container)
        {            
            //Console.WriteLine(serviceProvider.GetRequiredService<Book>());
            //Console.WriteLine(serviceProvider.GetRequiredService<Func<Book>>()());

            //using (var accessor = serviceProvider.CreateScopeAccessor())
            //    Console.WriteLine(accessor.ScopeServices.GetRequiredService<Func<Book>>()());            

            //Console.WriteLine(serviceProvider.GetRequiredService<Func<Book>>()());
        }
    }
}
