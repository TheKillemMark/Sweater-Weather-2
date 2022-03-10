using Sweater_Weather_2.Models;
using Sweater_Weather_2.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Sweater_Weather_2.ViewModels
{
    public class WeatherViewModel
    {
        private IList<OneCallAPI> _weatherList;
        public IList<OneCallAPI> WeatherList
        {
            get
            {
                if (_weatherList == null)
                {
                    _weatherList = new ObservableCollection<OneCallAPI>();
                }

                return _weatherList;
            }
            set => _weatherList = value;
        }

        private async Task APIAsync()
        {
            OneCallAPI weather = await WeatherAPI.GetOneCallAPIAsync(38.264790, -76.455032, "standard");
            //    var weather = await WeatherAPI.GetFiveDaysAsync("Lexington Park");
            WeatherList.Add(weather);
        }

        public WeatherViewModel()
        {
            Task task = Task.Run(APIAsync);
            _ = task;
        }
    }
}
