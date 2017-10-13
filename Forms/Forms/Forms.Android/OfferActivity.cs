using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

namespace Forms.Droid
{
    [Activity(Theme = "@android:style/Theme.Translucent.NoTitleBar", LaunchMode = LaunchMode.SingleInstance)]
    public class OfferActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            Window.SetLayout(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
            Window.AddFlags(WindowManagerFlags.ForceNotFullscreen | WindowManagerFlags.TurnScreenOn);
        }        
    }
}