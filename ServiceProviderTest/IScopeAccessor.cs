namespace ServiceProviderTest
{
    using System;

    public interface IScopeAccessor : IDisposable
    {
        Guid Id { get; }

        IServiceProvider ScopeServices { get; }
    }
}
