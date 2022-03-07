using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sweater_Weather_2.ViewModels
{
    public class SweaterWeatherViewModel : BindableObject
    {
        public SweaterWeatherViewModel()
        {
            IncreaseCount = new Command(OnIncrease);
        }
        public ICommand IncreaseCount { get; }
        int count = 0;
        string countDisplay = "Click Me!";

        void OnIncrease()
        {
            count++;
            CountDisplay = $"You clicked {count} time(s)!";
        }
        public string CountDisplay
        {
            get => countDisplay;
            set
            {
                if (value == countDisplay)
                    return;
                countDisplay = value;
                OnPropertyChanged(nameof(CountDisplay));
            }
        }
    }
}
