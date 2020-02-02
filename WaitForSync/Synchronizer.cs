namespace WaitForSync
{
    using System.Threading;
    using System.Threading.Tasks;

    public class Synchronizer
    {
        private readonly SemaphoreSlim semaphoreSlim = new SemaphoreSlim(0, 1);
        private int executing;

        public Synchronizer()
        {
            TaskScheduler.FromCurrentSynchronizationContext
        }

        public async Task Sync(string value = null)
        {            
            if (Interlocked.CompareExchange(ref executing, 1, 0) != 0)                
                return;
            
            try
            {
                await Task.Delay(5000);
            }
            finally
            {
                executing = 0;
            }
        }
    }
}
