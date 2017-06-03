using System;
using EF6Test.Data;

namespace EF6Test
{
    using EF6Test.Repositories;
    using Newtonsoft.Json;

    internal class Program
    {
        private static void Main()
        {
            Clean();
            //var driver = CreateDriver();
            //var order = CreateOrder(driver.Id);
            //Console.Write($@"driverId: {driver.Id}, orderId: {order.Id}");

            var searchRepository = new SearchRepository();
            var search = searchRepository.Create(1);
            var existingSearch = searchRepository.Read(search.Id);
            var oJson = JsonConvert.SerializeObject(search);
            var eJson = JsonConvert.SerializeObject(existingSearch);
            Console.WriteLine(oJson.Equals(eJson));

            search.State = 2;
            search.AddSuggestion(100);
            search.AddSuggestion(200);
            search.AddSuggestion(300);
            searchRepository.Update(search);
            existingSearch = searchRepository.Read(search.Id);
            oJson = JsonConvert.SerializeObject(search);
            eJson = JsonConvert.SerializeObject(existingSearch);
            Console.WriteLine(oJson.Equals(eJson));
        }

        private static void Clean()
        {
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Database.ExecuteSqlCommand(
                @"
                delete from [dbo].[Suggestion];
                delete from [dbo].[Search];
                delete from [dbo].[Order];
                delete from [dbo].[Driver]; 
                delete from [dbo].[Passenger]; 
                delete from [dbo].[Person];");
                ctx.SaveChanges();
            }
        }

        private static DriverData CreateDriver()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var data = ctx.Drivers.Add(new DriverData
                {
                    ExperienceFrom = 2000,
                    LicenseNumber = Guid.NewGuid().ToString("N"),
                    Person = new PersonData
                    {
                        Id = 1,
                        GivenNames = "Romashka",
                        FamilyName = "Oduvanchikoff",
                        CreatedAt = DateTimeOffset.Now,
                    }
                });

                ctx.SaveChanges();
                return data;
            }
        }

        private static OrderData CreateOrder(long driverId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var data = ctx.Orders.Add(new OrderData
                {
                    DriverId = driverId,
                    State = 1,
                    CreatedAt = DateTimeOffset.Now,
                });

                ctx.SaveChanges();
                return data;
            }
        }
    }
}