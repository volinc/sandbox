using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using Forms.Driving.Configuration;
using Newtonsoft.Json;

namespace Forms.Driving
{
    public class SettingsEditor : ISettingsEditor
    {
        private readonly ConcurrentDictionary<string, string> preferenses = new ConcurrentDictionary<string, string>();
        private readonly ConcurrentDictionary<string, string> sharedPreferences;

        private void AddOrUpdate<TValue>(string key, TValue value)
        {
            var newValue = JsonConvert.SerializeObject(value);
            if (!preferenses.TryAdd(key, newValue))
                preferenses[key] = newValue;
        }

        public SettingsEditor(ConcurrentDictionary<string, string> sharedPreferences)
        {
            this.sharedPreferences = sharedPreferences;
        }

        public Guid AppId
        {
            set => AddOrUpdate(nameof(ISettings.AppId), value);
        }

        public string Phone
        {
            set => AddOrUpdate(nameof(ISettings.Phone), value);
        }

        public string Password
        {
            set => AddOrUpdate(nameof(ISettings.Password), value);
        }

        public bool IsRememberMe
        {
            set => AddOrUpdate(nameof(ISettings.IsRememberMe), value);
        }

        public string LastTokenResponse
        {
            set => AddOrUpdate(nameof(ISettings.LastTokenData), value);
        }

        public string UiStore
        {
            set => AddOrUpdate(nameof(ISettings.UiStore), value);
        }

        public void Apply()
        {
            foreach (var preferense in preferenses)
            {
                if (!sharedPreferences.TryAdd(preferense.Key, preferense.Value))
                    sharedPreferences[preferense.Key] = preferense.Value;
            }

            Debug.WriteLine("Settings saved");
        }

        public void Dispose()
        {
            preferenses.Clear();
        }
    }
}
