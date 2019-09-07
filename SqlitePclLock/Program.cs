namespace SqlitePclLock
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Taxys.Geometry;
    using System.Threading;

    internal class Program
    {
        private async static Task Main()
        {
            var orderDbContext = new OrderDbContext();
            var orderLocationRepository = new OrderLocationRepository(orderDbContext);

            orderLocationRepository.DeleteAll();
            var max = orderLocationRepository.ReadMaxIndexOrNull();

            var tasks = Enumerable.Range(1, 1000).Select(x => RunAsync(orderLocationRepository));

            await Task.WhenAll(tasks);
            await Console.Out.WriteLineAsync("Done");
            await Console.In.ReadLineAsync();
        }


        private static async Task RunAsync(OrderLocationRepository orderLocationRepository)
        {
            await Task.Run(() => 
            {
                var location = new Location(0, 0);
                orderLocationRepository.Create(1, location, DateTimeOffset.UtcNow, 0, 0);
                orderLocationRepository.ReadAll();
                //orderLocationRepository.DeleteAll();

                //Console.Out.WriteLine($"Done {Thread.CurrentThread.ManagedThreadId} {Thread.CurrentThread.IsBackground}");

            }).ConfigureAwait(false);
        }
    }
}
