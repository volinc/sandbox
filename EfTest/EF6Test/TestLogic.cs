namespace EF6Test
{
    using System;
    using EF6Test.Data;
    using EF6Test.Repositories;
    using KellermanSoftware.CompareNetObjects;

    public class TestLogic
    {
        private readonly SearchRepository searchRepository;

        public TestLogic(SearchRepository searchRepository)
        {
            this.searchRepository = searchRepository;
        }

        public void Start()
        {
            Clean();
            //var driver = CreateDriver();
            //var order = CreateOrder(driver.Id);
            //Console.Write($@"driverId: {driver.Id}, orderId: {order.Id}");

            Console.WriteLine(1);
            var search = searchRepository.Create(1);
            var existingSearch = searchRepository.Read(search.Id);
            WriteComparison(search, existingSearch);

            // 2
            Console.WriteLine(2);
            search.AddSuggestion(100);
            search.AddSuggestion(200);
            search.AddSuggestion(300);
            searchRepository.Update(search);
            existingSearch = searchRepository.Read(search.Id);
            WriteComparison(search, existingSearch);

            Console.WriteLine(3);
            search.State = 3;
            foreach (var suggestion in search.Suggestions)
                suggestion.State = 2;
            searchRepository.Update(search);
            existingSearch = searchRepository.Read(search.Id);
            WriteComparison(search, existingSearch);

            Console.WriteLine(4);
            search = searchRepository.Read(existingSearch.Id);
            search.State = 4;
            foreach (var suggestion in search.Suggestions)
                suggestion.State = 3;
            searchRepository.Update(search);
            existingSearch = searchRepository.Read(search.Id);
            WriteComparison(search, existingSearch);
        }

        private static void WriteComparison(Domain.Search a, Domain.Search b)
        {
            var deepComparer = new CompareLogic();
            //Console.WriteLine(JsonConvert.SerializeObject(a, Formatting.Indented));
            //Console.WriteLine(JsonConvert.SerializeObject(b, Formatting.Indented));
            var compareResult = deepComparer.Compare(a, b);
            //Console.WriteLine(compareResult.DifferencesString);
            Console.WriteLine(compareResult.AreEqual);
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
