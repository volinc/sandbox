using Forms.Helpers;
using Forms.ViewModels;
using Xamarin.Forms;

namespace Forms.Views
{
	public class TrackingPage : ViewPage<TrackingViewModel>
    {
		public TrackingPage ()
		{
            Content = new StackLayout {
				Children = {
					new Label { Text = $"Lat: {ViewModel.Lat}"},
				    new Label { Text = $"Lon: {ViewModel.Lon}"},
                }
			};
		}
	}
}