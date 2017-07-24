using System;
using EF6Test.Data;

namespace EF6Test
{
    using Autofac;
    using EF6Test.Repositories;
    using Newtonsoft.Json;

    internal class Program
    {
        private static void Main()
        {
            var builder = new ContainerBuilder();
            builder.RegisterInstance(new Func<DateTimeOffset>(() => DateTimeOffset.Now)).SingleInstance();
            builder.RegisterType<ApplicationDbContext>().SingleInstance();            
            builder.RegisterType<DriverRepository>().SingleInstance();
            builder.RegisterType<VehicleRepository>().SingleInstance();
            builder.RegisterType<ShiftRepository>().SingleInstance();
            builder.RegisterType<PassengerRepository>().SingleInstance();
            builder.RegisterType<SearchRepository>().SingleInstance();
            builder.RegisterType<OrderRepository>().SingleInstance();
            builder.RegisterType<TestLogic>().SingleInstance();
            var container = builder.Build();

            var testLogic = container.Resolve<TestLogic>();
            testLogic.Start();                        
        }        
    }
}