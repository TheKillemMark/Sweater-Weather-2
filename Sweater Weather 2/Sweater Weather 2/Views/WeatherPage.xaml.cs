using Sweater_Weather_2.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sweater_Weather_2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage()
        {
            InitializeComponent();
            BindingContext = new WeatherViewModel();
        }
    }
}