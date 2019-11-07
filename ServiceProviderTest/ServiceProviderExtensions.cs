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

            var scopeAccessor = serviceProvider.GetRequiredService<ScopeAccessor>();
            scopeAccessor.CreateScope();

            return scopeAccessor;
        }

        public static Func<T> GetRequiredFunc<T>(this IServiceProvider serviceProvider)
        {
            if (serviceProvider == null)
                throw new ArgumentNullException(nameof(serviceProvider));

            var scopeAccessor = serviceProvider.GetRequiredService<ScopeAccessor>();
            return () => scopeAccessor.ScopeServices.GetRequiredService<T>();
        }
    }
}
