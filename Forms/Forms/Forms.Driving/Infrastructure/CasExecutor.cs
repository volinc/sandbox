using System;
using System.Threading;
using System.Threading.Tasks;

namespace Forms.Driving.Infrastructure
{
    /// <summary>
    /// Упрощенная реализация паттерна CAS, для исключения возможности повторного вызова и параллельного исполнения одного и того же метода.
    /// </summary>
    public class CasExecutor
    {
        private int executing;

        public void Execute(Action action)
        {
            if (Interlocked.CompareExchange(ref executing, 1, 0) != 0)
                return;

            try
            {
                action();
            }
            finally
            {
                executing = 0;
            }
        }

        public async Task ExecuteAsync(Func<Task> action)
        {
            if (Interlocked.CompareExchange(ref executing, 1, 0) != 0)
                return;

            try
            {
                await action();
            }
            finally
            {
                executing = 0;
            }
        }

        public async Task ExecuteAsync<T>(Func<T,Task> action, T arg0)
        {
            if (Interlocked.CompareExchange(ref executing, 1, 0) != 0)
                return;

            try
            {
                await action(arg0);
            }
            finally
            {
                executing = 0;
            }
        }        
    }
}
