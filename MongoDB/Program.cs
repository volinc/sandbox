using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MongoDB
{
    internal class Program
    {
        private static long _orderId;
        private static readonly Dictionary<long, int> OrderIdIndex = new Dictionary<long, int>();

        private static void Main()
        {
            var sw = new Stopwatch();
            Run();

            var ticks = new List<long>();
            for (var i = 0; i < 10; i++)
            {
                sw.Start();
                Run();
                sw.Stop();
                ticks.Add(sw.ElapsedTicks);                
                sw.Reset();   
            }
            Console.WriteLine($"min: {TimeSpan.FromTicks(ticks.Min())}");
            Console.WriteLine($"max: {TimeSpan.FromTicks(ticks.Max())}");
            Console.WriteLine($"avg: {TimeSpan.FromTicks((long)ticks.Average())}");

            Console.ReadLine();
        }

        private static void Run()
        {
            var orderTrackRepository = new OrderTrackPointRepository("mongodb://localhost:27017");
            
            var orderId = GetNextOrderId();
            orderTrackRepository.DeleteByOrderId(orderId);
            
            orderTrackRepository.CreateAsync(orderId, GetNextIndexByOrderId(orderId), GetRandomLocation(), GetTimestamp());            
            orderTrackRepository.CreateAsync(orderId, GetNextIndexByOrderId(orderId), GetRandomLocation(), GetTimestamp());
            orderTrackRepository.CreateAsync(orderId, GetNextIndexByOrderId(orderId), GetRandomLocation(), GetTimestamp());
            orderTrackRepository.CreateAsync(orderId, GetNextIndexByOrderId(orderId), GetRandomLocation(), GetTimestamp());
            orderTrackRepository.CreateAsync(orderId, GetNextIndexByOrderId(orderId), GetRandomLocation(), GetTimestamp());
            orderTrackRepository.CreateAsync(orderId, GetNextIndexByOrderId(orderId), GetRandomLocation(), GetTimestamp());

            orderId = GetNextOrderId();
            orderTrackRepository.DeleteByOrderId(orderId);

            orderTrackRepository.CreateAsync(orderId, GetNextIndexByOrderId(orderId), GetRandomLocation(), GetTimestamp());
            orderTrackRepository.CreateAsync(orderId, GetNextIndexByOrderId(orderId), GetRandomLocation(), GetTimestamp());
            orderTrackRepository.CreateAsync(orderId, GetNextIndexByOrderId(orderId), GetRandomLocation(), GetTimestamp());

            var last = orderTrackRepository.ReadLastByOrderId(orderId);
            var all = orderTrackRepository.ReadAllByOrderId(orderId);
        }

        private static long GetNextOrderId() => ++_orderId;        

        private static int GetNextIndexByOrderId(long orderId)
        {
            if (OrderIdIndex.TryGetValue(orderId, out var index))
                OrderIdIndex[orderId] = ++index;
            else
                OrderIdIndex.Add(orderId, ++index);

            return index;
        }

        private static Location GetRandomLocation()
        {
            var r = new Random(DateTime.Now.Millisecond + DateTime.Now.Second);
            return new Location(r.NextDouble(), r.NextDouble());
        }

        private static DateTimeOffset GetTimestamp() => DateTimeOffset.Now;
    }
}
