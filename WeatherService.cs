using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PlanifApp
{
    public class WeatherService
    {
        public static async Task<WeatherObject> CallWebAPIAsync()
        {
            string url = "https://api.meteo-concept.com/api/forecast/";
            string request = "daily?latlng=45.166%2C5.716&insee=35238&world=false&start=1&end=1&token=f38a7dd53af4c45dd379dfcf7f65e975642c03d195aa47b6b7422985ddf34307";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //GET Method
            HttpResponseMessage response = await client.GetAsync(request);
            if (response.IsSuccessStatusCode)
            {
                WeatherObject weather = await response.Content.ReadAsAsync<WeatherObject>();
                Console.WriteLine(weather.City.Name);
                Console.WriteLine(weather.Forecast[0].Probarain);
                return weather;
            }
            else
            {
                Console.WriteLine("Internal server Error");
                return new WeatherObject();
            }
        }
    }
}
