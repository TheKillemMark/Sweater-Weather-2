using Xamarin.Forms;

namespace Sweater_Weather_2
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            AppShell appShell = new AppShell();
            MainPage = appShell;
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
