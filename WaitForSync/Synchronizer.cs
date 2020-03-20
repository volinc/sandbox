namespace WaitForSync
{
    using System;
    using System.Threading.Tasks;
    
    public class Synchronizer
    {
        private static readonly Random Random = new Random();
        private readonly TaskQueue queue = new TaskQueue();

        public async Task SynchronizeAsync(string value)
        {
            await queue.Enqueue(() => SynchronizeIntenalAsync(value));
        }

        private static async Task SynchronizeIntenalAsync(string value)
        {
            //var delay = Random.Next(5, 100);
            //await Task.Delay(delay);
            await Console.Out.WriteLineAsync(value);
        }
    }
}
