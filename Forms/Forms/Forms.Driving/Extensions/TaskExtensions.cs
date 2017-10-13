using System;
using System.Linq;
using System.Threading.Tasks;

namespace Forms.Driving.Extensions
{
    /// <summary>
    /// Реализует метод расширения <see cref="Forget"/> для <see cref="Task">задач</see>.
    /// </summary>
    public static class TaskExtensions
    {
        /// <summary>
        /// Метод позволяет избавиться от предупреждения CS4014
        /// (Because this call is not awaited, execution of the current method continues before the call is completed.
        /// Consider applying the 'await' operator to the result of the call.)
        /// </summary>
        /// <remarks>
        /// См. <see cref="!:https://msdn.microsoft.com/ru-ru/library/hh873131.aspx">детали.</see>.
        /// Такой способ описан на странице http://stackoverflow.com/questions/22629951/suppressing-warning-cs4014-because-this-call-is-not-awaited-execution-of-the.
        /// </remarks>
        /// <param name="task">Задача для игнорирования.</param>
        /// <param name="acceptableExceptions">Перечень типов исключений, которые не должны приводить к ошибкам.</param>
        public static async void Forget(this Task task, params Type[] acceptableExceptions)
        {
            // Подробно паттерн описан в статье http://stackoverflow.com/questions/22864367/fire-and-forget-approach
            try
            {
                await task.ConfigureAwait(false);
            }
            catch (Exception exception)
            {
                if (acceptableExceptions == null || !acceptableExceptions.Contains(exception.GetType()))
                    throw;
            }
        }

        public static async Task ForgetWithTask(this Task task, params Type[] acceptableExceptions)
        {
            try
            {
                await task;
            }
            catch (Exception exception)
            {
                if (acceptableExceptions == null || !acceptableExceptions.Contains(exception.GetType()))
                    throw;
            }            
        }

        public static async Task<T> ForgetWithDefault<T>(this Task<T> task, params Type[] acceptableExceptions)
        {
            try
            {
                return await task;
            }
            catch (Exception exception)
            {
                if (acceptableExceptions == null || !acceptableExceptions.Contains(exception.GetType()))
                    throw;                                
            }

            return default(T);
        }
    }
}