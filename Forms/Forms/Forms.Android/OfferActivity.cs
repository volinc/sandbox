using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Java.Interop;

namespace Forms.Droid
{
    [Activity(Theme = "@android:style/Theme.Translucent.NoTitleBar", LaunchMode = LaunchMode.SingleInstance)]
    public class OfferActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Offer);
            Window.SetLayout(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
            Window.AddFlags(WindowManagerFlags.ForceNotFullscreen | WindowManagerFlags.TurnScreenOn);
        }

        [Export("buttonAcceptClick")]
        public void ButtonAcceptClick(View view)
        {
            Finish();
        }

        [Export("buttonDeclineClick")]
        public void ButtonDeclineClick(View view)
        {
            Finish();
        }
    }
}