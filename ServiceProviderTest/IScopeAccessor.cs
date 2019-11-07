namespace ServiceProviderTest
{
    using System;

    public interface IScopeAccessor : IDisposable
    {
        IServiceProvider ScopeServices { get; }
    }
}
