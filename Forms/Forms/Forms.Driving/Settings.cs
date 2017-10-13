using System;
using System.Collections.Concurrent;
using Forms.Driving.Configuration;
using Newtonsoft.Json;

namespace Forms.Driving
{
    public class Settings : ISettings
    {
        private readonly ConcurrentDictionary<string, string> sharedPreferences = new ConcurrentDictionary<string, string>();

        public Guid AppId => sharedPreferences.TryGetValue(nameof(ISettings.AppId), out var value)
            ? JsonConvert.DeserializeObject<Guid>(value)
            : default(Guid);

        public string Phone => sharedPreferences.TryGetValue(nameof(ISettings.Phone), out var value)
            ? JsonConvert.DeserializeObject<string>(value)
            : default(string);

        public string Password => sharedPreferences.TryGetValue(nameof(ISettings.Password), out var value)
            ? JsonConvert.DeserializeObject<string>(value)
            : default(string);

        public bool IsRememberMe => sharedPreferences.TryGetValue(nameof(ISettings.IsRememberMe), out var value) &&
                                    JsonConvert.DeserializeObject<bool>(value);

        public string LastTokenData => sharedPreferences.TryGetValue(nameof(ISettings.LastTokenData), out var value)
            ? JsonConvert.DeserializeObject<string>(value)
            : default(string);

        public string UiStore => sharedPreferences.TryGetValue(nameof(ISettings.UiStore), out var value)
            ? JsonConvert.DeserializeObject<string>(value)
            : default(string);

        public ISettingsEditor CreateEditor()
        {
            return new SettingsEditor(sharedPreferences);
        }        
    }
}
