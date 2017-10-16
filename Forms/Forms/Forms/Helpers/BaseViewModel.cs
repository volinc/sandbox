using System;

namespace Forms.Helpers
{
    public class BaseViewModel : ObservableObject, IDisposable
    {
        public virtual void Dispose()
        {
        }

        private bool _isBusy;

        public virtual bool IsBusy
        {
            get => _isBusy;
            protected set => SetProperty(ref _isBusy, value);
        }
    }
}
