using System.Collections.Concurrent;

namespace WaitForSync
{
    using System.Threading;
    using System;
    using System.Threading.Tasks;
    
    public class Synchronizer
    {
        private int executing;
        private static readonly Random Random = new Random();
        
        private readonly ConcurrentQueue<Task> tasks = new ConcurrentQueue<Task>();

        private readonly TaskQueue queue = new TaskQueue();

        public async Task SynchronizeAsync(string value)
        {
            //await SynchronizeIntenalAsync(value);
            await queue.Enqueue(() => SynchronizeIntenalAsync(value));

            //var task = new Task(() => SynchronizeIntenalAsync(value).Wait());
            //tasks.Enqueue(task);

            //if (Interlocked.CompareExchange(ref executing, 1, 0) != 0)
            //{
            //    await Task.WhenAll(tasks);
            //    return;
            //}

            //try
            //{
            //    if (tasks.TryDequeue(out task))
            //    {
            //        task.Start();
            //        await task.ContinueWith(t =>
            //        {
            //            if (tasks.TryDequeue(out task))
            //                task.Start();
            //        });
            //    }
            //}
            //finally
            //{
            //    executing = 0;
            //}
        }

        private static async Task SynchronizeIntenalAsync(string value)
        {
            var delay = Random.Next(5, 500);
            await Task.Delay(delay);
            await Console.Out.WriteLineAsync(value);
        }
    }
}
