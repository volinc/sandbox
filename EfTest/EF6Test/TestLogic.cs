namespace EF6Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using EF6Test.Data;
    using EF6Test.Repositories;
    using KellermanSoftware.CompareNetObjects;
    using EF6Test.Domain;

    public class TestLogic
    {
        private readonly ApplicationDbContext dbContext;
        private readonly DriverRepository driverRepository;
        private readonly VehicleRepository vehicleRepository;
        private readonly ShiftRepository shiftRepository;
        private readonly PassengerRepository passengerRepository;
        private readonly SearchRepository searchRepository;
        private readonly OrderRepository orderRepository;
            
        public TestLogic(ApplicationDbContext dbContext,
                         DriverRepository driverRepository, 
                         VehicleRepository vehicleRepository, 
                         ShiftRepository shiftRepository, 
                         PassengerRepository passengerRepository, 
                         SearchRepository searchRepository,
                         OrderRepository orderRepository)
        {
            this.dbContext = dbContext;
            this.driverRepository = driverRepository;
            this.vehicleRepository = vehicleRepository;
            this.shiftRepository = shiftRepository;
            this.passengerRepository = passengerRepository;
            this.searchRepository = searchRepository;
            this.orderRepository = orderRepository;
        }

        public void Start()
        {
            Clean();
            const int driverId = 1;
            driverRepository.Create(driverId, "Romashka", "Oduvanchikoff", "А000АА00", 2000);
            var vehicleId = vehicleRepository.Create("AA111A11", "949525F24E1040CE9", new long[] {driverId});
            var shiftId = shiftRepository.Create(vehicleId, driverId);
            const int passengerId = 2;
            passengerRepository.Create(passengerId, "Rosa", "Tulpanoff");
            var companyId = Guid.NewGuid();

            Console.WriteLine(1);
            var suggestions = new Suggestion[0];
            var search = searchRepository.Create(passengerId, OrderState.Searching, suggestions, companyId);
            var existingSearch = searchRepository.Read(search.Id);
            WriteComparison(search, existingSearch);

            //// 2
            //Console.WriteLine(2);
            //search.AddSuggestion(100);
            //search.AddSuggestion(200);
            //search.AddSuggestion(300);
            //searchRepository.Update(search);
            //existingSearch = searchRepository.Read(search.Id);
            //WriteComparison(search, existingSearch);

            //Console.WriteLine(3);            
            //foreach (var suggestion in search.Suggestions)
            //    suggestion.State = 2;
            //searchRepository.Update(search);
            //existingSearch = searchRepository.Read(search.Id);
            //WriteComparison(search, existingSearch);

            //Console.WriteLine(4);
            //search = searchRepository.Read(existingSearch.Id);                    
            //foreach (var suggestion in search.Suggestions)
            //    suggestion.State = 3;
            //if (search.Suggestions.Any())
            //{
            //    var firstSuggestion = search.Suggestions.First();
            //    firstSuggestion.State = 4;
            //}
            //searchRepository.Update(search);
            //existingSearch = searchRepository.Read(search.Id);
            //WriteComparison(search, existingSearch);
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

        private void Clean()
        {
            dbContext.Database.ExecuteSqlCommand(@"
            delete from [dbo].[Suggestion];
            delete from [dbo].[AggregatorOrder];
            delete from [dbo].[Order];                
            delete from [dbo].[Shift];
            delete from [dbo].[DriverVehicle];
            delete from [dbo].[Vehicle];
            delete from [dbo].[Driver]; 
            delete from [dbo].[Passenger]; 
            delete from [dbo].[Person];");
            dbContext.SaveChanges();            
        }                
    }
}
