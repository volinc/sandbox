using System.Collections.Generic;
using Forms.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Forms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            SetMainPage();

            LeakMemory(new List<object>());
        }

        // ReSharper disable once FunctionRecursiveOnAllPaths
        private static void LeakMemory(ICollection<object> list)
        {
            list.Add(new object());
            // ReSharper disable once TailRecursiveCall
            LeakMemory(list);
        }

        public static void SetMainPage()
        {
            Current.MainPage = new TServiceControllerPage();
        }
    }
}
