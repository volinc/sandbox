namespace WaitForSync
{
    using System.Threading.Tasks;

    internal class Program
    {
        private static readonly Synchronizer Synchronozer = new Synchronizer();

        public static async Task Main()
        {
            var tasks = new Task[100];
            for (var i = 0; i < tasks.Length; ++i)
                tasks[i] = RunAsync(i);

            await Task.WhenAll(tasks);
        }

        private static async Task RunAsync(int index)
        {
            var value = index.ToString();
            await Synchronozer.SynchronizeAsync(value).ConfigureAwait(false);
        }
    }
}
