namespace ServiceProviderTest
{
    using System;
    using Microsoft.Extensions.DependencyInjection;

    public static class ServiceProviderExtensions
    {
        public static ContextScope CreateContextScope(this IServiceProvider serviceProvider)
        {
            if (serviceProvider == null)
                throw new ArgumentNullException(nameof(serviceProvider));

            var contextScope = serviceProvider.GetRequiredService<ContextScope>();
            contextScope.Init();
            return contextScope;
        }

        public static Func<T> GetRequiredFunc<T>(this IServiceProvider serviceProvider)
        {
            if (serviceProvider == null)
                throw new ArgumentNullException(nameof(serviceProvider));

            var scopeAccessor = serviceProvider.GetRequiredService<ContextScope>();
            
            return () => scopeAccessor.ServiceProvider.GetRequiredService<T>();
        }
    }
}
