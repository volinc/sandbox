using Autofac;
using Forms.Helpers;

namespace Forms
{
    public class ViewModelFactory
    {
        private readonly ILifetimeScope _lifetimeScope;

        public ViewModelFactory(ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
        }

        public TViewModel Create<TViewModel>() where TViewModel : BaseViewModel
        {
            return _lifetimeScope.Resolve<TViewModel>();
        }
    }
}
