using Xamarin.Forms;

namespace Forms.Helpers
{
    public class ViewPage<TViewModel> : ContentPage where TViewModel : BaseViewModel, new()
    {
        public TViewModel ViewModel { get; }

        public ViewPage()
        {
            ViewModel = new TViewModel();
            BindingContext = ViewModel;
        }
    }
}
