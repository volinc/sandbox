using Forms.Helpers;
using Forms.ViewModels;
using Xamarin.Forms;

namespace Forms.Views
{
	public class TrackingPage : ViewPage<TrackingViewModel>
    {
		public TrackingPage ()
		{
		    var latLabel = new Label();
		    latLabel.SetBinding(Label.TextProperty, nameof(ViewModel.Lat), stringFormat: "Lat {0}");

		    var lonLabel = new Label();
		    latLabel.SetBinding(Label.TextProperty, nameof(ViewModel.Lon), stringFormat: "Lon {0}");

		    Content = new StackLayout
		    {
		        Children =
		        {
		            latLabel,
		            lonLabel
		        }
		    };
		}
	}
}