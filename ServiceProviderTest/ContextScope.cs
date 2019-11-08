namespace ServiceProviderTest
{
    using System.Threading;
    using Microsoft.Extensions.DependencyInjection;
    using System;

    public class ContextScope : IDisposable
    {
        private static readonly AsyncLocal<IServiceScope> CurrentScope = new AsyncLocal<IServiceScope>();
        private readonly IServiceProvider serviceProvider;

        public ContextScope(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public IServiceProvider ServiceProvider => CurrentScope.Value?.ServiceProvider ?? serviceProvider;

        internal void Init()
        {
            var scopeValue = CurrentScope.Value;
            if (scopeValue != null)
            {
                scopeValue.Dispose();
                CurrentScope.Value = null;
            }
            
            CurrentScope.Value = serviceProvider.CreateScope();
        }

        public void Dispose()
        {
            var scopeValue = CurrentScope.Value;
            if (scopeValue != null)
            {
                scopeValue.Dispose();
                CurrentScope.Value = null;
            }
        }
    }
}
