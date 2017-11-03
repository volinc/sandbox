using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Forms.ViewModels
{
    public class MultiSelectionViewModel
    {
        public ObservableCollection<MultiSelectionItem> Items { get; } = new ObservableCollection<MultiSelectionItem>
        {
            new MultiSelectionItem { Name = "Категория A", Value = false },
            new MultiSelectionItem { Name = "Категория B", Value = false },
            new MultiSelectionItem { Name = "Категория C", Value = false }
        };

        public ICommand AcceptCommand => new Command(async () =>
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        });

        public ICommand CancelCommand => new Command(async () =>
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        });
    }
}
