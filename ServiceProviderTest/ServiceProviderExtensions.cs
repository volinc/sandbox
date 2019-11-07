namespace ServiceProviderTest
{
    using System;
    using Microsoft.Extensions.DependencyInjection;

    public static class ServiceProviderExtensions
    {
        public static IScopeAccessor CreateScopeAccessor(this IServiceProvider serviceProvider)
        {
            if (serviceProvider == null)
                throw new ArgumentNullException(nameof(serviceProvider));

            var serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope();
            var scopeAccessor = serviceScope.ServiceProvider.GetRequiredService<ScopeAccessor>();
            scopeAccessor.Init(serviceScope);

            return scopeAccessor;
        }

        public static Func<T> GetRequiredFunc<T>(this IServiceProvider serviceProvider)
        {
            if (serviceProvider == null)
                throw new ArgumentNullException(nameof(serviceProvider));

            var scopeAccessor = serviceProvider.GetRequiredService<ScopeAccessor>();
            if (scopeAccessor.ScopeServices == null)
                return serviceProvider.GetRequiredService<T>;

            return () => scopeAccessor.ScopeServices.GetRequiredService<T>();
        }
    }
}
