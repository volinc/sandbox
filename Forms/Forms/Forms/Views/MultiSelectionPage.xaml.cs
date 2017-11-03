using Forms.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MultiSelectionPage : ContentPage
	{
		public MultiSelectionPage ()
		{
			InitializeComponent ();
		    BindingContext = new MultiSelectionViewModel();
		}
	}
}