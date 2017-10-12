using Forms.Helpers;
using Forms.ViewModels;
using Xamarin.Forms.Xaml;

namespace Forms.Views
{
    public class TrackingPageBase : ViewPage<TrackingViewModel> { }

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TrackingPage : TrackingPageBase
    {
		public TrackingPage ()
		{
			InitializeComponent ();
		}
	}
}