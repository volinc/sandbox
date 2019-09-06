using System.Threading;

namespace SqlitePclLock
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Taxys.Geometry;

    internal class Program
    {
        private static void Main()
        {
            var orderDbContext = new OrderDbContext();
            var orderLocationRepository = new OrderLocationRepository(orderDbContext);

            orderLocationRepository.DeleteAll();
            var max = orderLocationRepository.ReadMaxIndexOrNull();

            var location = new Location(0, 0);
            orderLocationRepository.Create(1, location, DateTimeOffset.UtcNow, 0, 0);
            
            orderLocationRepository.DeleteAll();
            orderLocationRepository.Create(1, location, DateTimeOffset.UtcNow, 0, 0);
            var all = orderLocationRepository.ReadAll();

            orderLocationRepository.Create(1, location, DateTimeOffset.UtcNow, 0, 0);

            foreach (var _ in Enumerable.Range(1, 1000))
                Task.Run(() => RunAsync(orderLocationRepository)).ConfigureAwait(false);


            Console.WriteLine("Done");
            Console.ReadLine();
        }


        private static Task RunAsync(OrderLocationRepository orderLocationRepository)
        {
            var location = new Location(0, 0);
            orderLocationRepository.Create(1, location, DateTimeOffset.UtcNow, 0, 0);
            orderLocationRepository.ReadAll();
            orderLocationRepository.DeleteAll();

            Console.WriteLine($"Done {Thread.CurrentThread.ManagedThreadId} {Thread.CurrentThread.IsBackground}");

            return Task.CompletedTask;
        }
    }
}
