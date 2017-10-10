using Xamarin.Forms;

namespace Forms.Helpers
{
    public class ViewPage<TViewModel> : ContentPage where TViewModel : BaseViewModel
    {
        public TViewModel ViewModel { get; }

        public ViewPage()
        {
            ViewModel = App.ViewModelFactory.Create<TViewModel>();
            BindingContext = ViewModel;
        }
    }
}
