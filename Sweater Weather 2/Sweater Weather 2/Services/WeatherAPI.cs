using Newtonsoft.Json;
using Sweater_Weather_2.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace Sweater_Weather_2.Services
{
    public class WeatherAPI
    {
        public const string OPENWEATHERMAP_API_KEY = "db64233b6af9774cadc12e9bcf93b964";
        public const string BASE_URL = "https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&units={2}&appid={3}";
        public static async Task<OneCallAPI> GetOneCallAPIAsync(double lat, double lon, string units)
        {
            OneCallAPI weather = new OneCallAPI();
            string url = string.Format(BASE_URL, lat, lon, units, OPENWEATHERMAP_API_KEY);
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                OneCallAPI posts = JsonConvert.DeserializeObject<OneCallAPI>(content);
                weather = posts;
            }
            return weather;
        }
    }
}
