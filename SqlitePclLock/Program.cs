namespace SqlitePclLock
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Taxys.Geometry;
    using System.Threading;

    internal class Program
    {
        private static void Main()
        {
            var cancellation = new CancellationTokenSource();
            var cancellationToken = cancellation.Token;

            var orderDbContext = new OrderDbContext();
            var orderLocationRepository = new OrderLocationRepository(orderDbContext);
            orderLocationRepository.DeleteAll();
            var max = orderLocationRepository.ReadMaxIndexOrNull();

            var tasks = Enumerable.Range(1, 1000).Select(x => RunAsync(orderLocationRepository, cancellationToken));
            
            var task = Task.WhenAll(tasks).ContinueWith(t =>
            {
                if (t.IsFaulted)
                {
                    Console.WriteLine("Faulted");
                    Console.WriteLine();
                    var ae = t.Exception.Flatten().InnerExceptions.FirstOrDefault();
                    Console.WriteLine(ae);
                }

                if (t.IsCompletedSuccessfully)
                    Console.WriteLine("Completed");
            });

            Console.ReadLine();
            if (!task.IsCompleted)
            {
                cancellation.Cancel();
                Console.WriteLine("Canceled");
            }
        }

        private static Task RunAsync(OrderLocationRepository orderLocationRepository, CancellationToken cancellationToken)
        {
            return Task.Run(() => 
            {
                var location = new Location(0, 0);
                orderLocationRepository.Create(1, location, DateTimeOffset.UtcNow, 0, 0);
                orderLocationRepository.ReadAll();
                orderLocationRepository.DeleteAll();
                Console.Out.WriteLine($"Done {Thread.CurrentThread.ManagedThreadId} {Thread.CurrentThread.IsBackground}");

            }, cancellationToken);
        }
    }
}
