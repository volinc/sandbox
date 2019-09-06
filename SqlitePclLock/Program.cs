using System.Threading;

namespace SqlitePclLock
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Taxys.Geometry;

    internal class Program
    {
        private async static Task Main()
        {
            var orderDbContext = new OrderDbContext();
            var orderLocationRepository = new OrderLocationRepository(orderDbContext);

            orderLocationRepository.DeleteAll();

            var tasks = Enumerable.Range(1, 1000).Select(x => RunAsync(orderLocationRepository));

            await Task.WhenAll(tasks).ConfigureAwait(false);

            var all = orderLocationRepository.ReadAll();

            Console.WriteLine("Done");
            Console.ReadLine();
        }


        private static Task RunAsync(OrderLocationRepository orderLocationRepository)
        {
            return Task.Run(() =>
            {
                var location = new Location(0, 0);
                orderLocationRepository.Create(1, location, DateTimeOffset.UtcNow, 0, 0);
                orderLocationRepository.ReadAll();
                //orderLocationRepository.DeleteAll();

                Console.WriteLine($"Done {Thread.CurrentThread.ManagedThreadId} {Thread.CurrentThread.IsBackground}");
            });
        }
    }
}
