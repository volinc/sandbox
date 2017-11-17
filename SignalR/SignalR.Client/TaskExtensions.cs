using System.Threading.Tasks;

namespace SignalR.Client
{
    public static class TaskExtensions
    {
        public static async void Forget(this Task task)
        {            
            await task.ConfigureAwait(false);            
        }
    }
}
