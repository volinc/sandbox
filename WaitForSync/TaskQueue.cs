namespace WaitForSync
{
    using System;
    using System.Threading.Tasks;

    public class TaskQueue
    {
        private readonly object sync = new object();
        private readonly WeakReference<Task> lastTask = new WeakReference<Task>(null);

        public Task Enqueue(Func<Task> asyncAction)
        {
            lock (sync)
            {
                var resultTask = lastTask.TryGetTarget(out var task) 
                    ? task.ContinueWith(_ => asyncAction(), TaskContinuationOptions.ExecuteSynchronously).Unwrap() 
                    : Task.Run(asyncAction);

                lastTask.SetTarget(resultTask);
                
                return resultTask;
            }
        }

        public Task<T> Enqueue<T>(Func<Task<T>> asyncFunction)
        {
            lock (sync)
            {
                var resultTask = lastTask.TryGetTarget(out var task) 
                    ? task.ContinueWith(_ => asyncFunction(), TaskContinuationOptions.ExecuteSynchronously).Unwrap() 
                    : Task.Run(asyncFunction);

                lastTask.SetTarget(resultTask);
                
                return resultTask;
            }
        }
    }
}
