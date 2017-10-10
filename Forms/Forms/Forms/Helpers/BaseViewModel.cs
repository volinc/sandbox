using System;

namespace Forms.Helpers
{
    public class BaseViewModel : ObservableObject, IDisposable
    {
        public virtual void Dispose()
        {
        }
    }
}
