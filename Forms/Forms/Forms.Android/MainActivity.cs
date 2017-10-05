using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Autofac;

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

        protected override void OnStart()
        {
            base.OnStart();

            var serviceIntent = new Intent(this, typeof(TService));
            BindService(serviceIntent, this, Bind.AutoCreate);
        }

        public void OnServiceConnected(ComponentName name, IBinder service)
        {
            var serviceBinder = service as TServiceBinder;

            var builder = new ContainerBuilder();
            var container = builder.Build();            
        }

        public void OnServiceDisconnected(ComponentName name)
        {
            
        }
    }
}