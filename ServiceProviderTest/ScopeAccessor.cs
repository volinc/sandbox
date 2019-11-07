namespace ServiceProviderTest
{
    using Microsoft.Extensions.DependencyInjection;
    using System;

    internal class ScopeAccessor : IScopeAccessor
    {
        private IServiceScope serviceScope;

        public Guid Id { get; } = Guid.NewGuid();

        public IServiceProvider ScopeServices => serviceScope?.ServiceProvider;
        
        internal void Init(IServiceScope scope)
        {
            if (serviceScope != null)
                throw new InvalidOperationException("Scope already set.");

            serviceScope = scope;            
        }

        public void Dispose()
        {
            if (serviceScope == null)
                return;
            
            serviceScope.Dispose();
            serviceScope = null;
        }
    }
}
