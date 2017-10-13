using System;

namespace Forms.Driving.Configuration
{
    public interface ISettingsEditor: IDisposable
    {
        Guid AppId { set; }
        
        string Phone { set; }
        
        string Password { set; }
        
        bool IsRememberMe { set; }
        
        string LastTokenResponse { set; }

        string UiStore { set; }

        void Apply();
    }
}