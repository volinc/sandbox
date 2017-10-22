using System;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Forms.Helpers
{
    public class BaseViewModel : ObservableObject, IDisposable
    {
        public virtual void Dispose()
        {
        }

        public virtual bool IsBusy { get; set; }

        public T GetPersistentValue<T>([CallerMemberName]string propertyName = "")
        {
            var key = StoreHelper.GeneratePropertyKey(GetType(), propertyName);
            TryGetPersistentValue(key, out T value);

            return value;
        }

        public void SetPersistentValue<T>(T value, [CallerMemberName] string propertyName = "", Action onChanged = null)
        {
            var key = StoreHelper.GeneratePropertyKey(GetType(), propertyName);
            TryGetPersistentValue(key, out T storedValue);

            if (SetProperty(ref storedValue, value, propertyName, onChanged))
                Application.Current.Properties[key] = value;
        }

        private static bool TryGetPersistentValue<T>(string key, out T value)
        {
            if (Application.Current.Properties.TryGetValue(key, out var objectValue))
            {
                if (objectValue is T storedValue)
                {
                    value = storedValue;
                    return true;
                }
            }

            value = default(T);

            return false;
        }
    }
}
