namespace ServiceProviderTest
{
    using Microsoft.Extensions.DependencyInjection;
    using System;

    public class ScopeAccessor : IScopeAccessor
    {                
        private readonly IServiceProvider serviceProvider;
        private IServiceScope serviceScope;

        public ScopeAccessor(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }        

        public IServiceProvider ScopeServices => serviceScope?.ServiceProvider ?? serviceProvider;
        
        public void CreateScope()
        {
            if (serviceScope != null)
                return;

            serviceScope = serviceProvider.CreateScope();            
        }

        public void Dispose()
        {
            serviceScope?.Dispose();
            serviceScope = null;
        }
    }
}
