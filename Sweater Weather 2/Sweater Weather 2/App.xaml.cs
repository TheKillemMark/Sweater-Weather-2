using Sweater_Weather_2.ViewModels;
using Sweater_Weather_2.Views;
using Xamarin.Forms;

namespace Sweater_Weather_2
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            //AppShell appShell = new AppShell();
            //MainPage = appShell;
            //MainPage = new NavigationPage(new TabbedPage1());
            //MainPage = new NavigationPage(new MainPage());
            WeatherPage root = new WeatherPage();
            MainPage = new NavigationPage(root);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
