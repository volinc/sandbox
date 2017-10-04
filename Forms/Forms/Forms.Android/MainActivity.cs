using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;

namespace Forms.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity, IServiceConnection
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            LoadApplication(new App());
        }

        public void OnServiceConnected(ComponentName name, IBinder service)
        {
            throw new System.NotImplementedException();
        }

        public void OnServiceDisconnected(ComponentName name)
        {
            throw new System.NotImplementedException();
        }
    }
}