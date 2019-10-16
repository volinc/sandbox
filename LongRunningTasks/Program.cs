namespace LongRunningTasks
{
    using System;
    using System.Threading.Tasks;

    internal class Program
    {
        private static async Task Main()
        {
            await Console.Out.WriteLineAsync("0");

            Delay().ConfigureAwait(false).GetAwaiter();

            await Console.Out.WriteLineAsync("3");
            await Console.In.ReadLineAsync();
        }

        private static async Task Delay()
        {
            await Console.Out.WriteLineAsync("1");
            await Task.Delay(15000);
            await Console.Out.WriteLineAsync("2");
        }
    }
}
