using System;

namespace Forms.Driving.Configuration
{
    public interface ISettings
    {
        Guid AppId { get; }

        string Phone { get; }
        
        string Password { get; }
        
        bool IsRememberMe { get; }
        
        string LastTokenData { get; }
        
        ISettingsEditor CreateEditor();

        string UiStore { get; }
    }
}