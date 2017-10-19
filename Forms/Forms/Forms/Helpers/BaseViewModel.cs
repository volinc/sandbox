using System;

namespace Forms.Helpers
{
    public class BaseViewModel : ObservableObject, IDisposable
    {
        public virtual void Dispose()
        {
        }

        public virtual bool IsBusy { get; set; }
    }
}
