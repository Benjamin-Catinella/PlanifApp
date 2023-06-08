using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanifApp
{
    public class ModelViewWeather
    {
        public string City { get; set; }

        public int TempMin { get; set; }

        public int TempMax { get; set; }

        public int RainProba { get; set; }

        public int Wind { get; set; }

        public ModelViewWeather() 
        {
            City = "grenoble";
            TempMin = 23; 
            TempMax = 45;
            RainProba = 56;
            Wind = 152;
            
            WeatherService.CallWebAPIAsync();
        }
    }
}
