using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanifApp
{
    /// <summary>
    /// Modèle des données récupérées via l'API.
    /// </summary>
    public class ModelWeather
    {

    }

    /// <summary>
    /// Classe city et ses attributs.
    /// </summary>
    public class City
    {
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Altitude { get; set; }
        public string Country { get; set; }
        public string CityName { get; set; }
    }

    /// <summary>
    /// Classe Forecast et ses attributs.
    /// </summary>
    public class Forecast
    {
        public string Country { get; set; }
        public string City { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime DateTime { get; set; }
        public double Wind10m { get; set; }
        public double Gust10m { get; set; }
        public double Dirwind10m { get; set; }
        public double Weather { get; set; }
        public double Probafrost { get; set; }
        public double Probafog { get; set; }
        public double Probawind70 { get; set; }
        public double Probawind100 { get; set; }
        public double Probarain { get; set; }
        public int Day { get; set; }
        public double Rr10 { get; set; }
        public double Rr1 { get; set; }
        public int Tmin { get; set; }
        public int Tmax { get; set; }
        public double SunHours { get; set; }
        public double Etp { get; set; }
        public double Gustx { get; set; }
    }

    /// <summary>
    /// Classe WeatherObject et ses attributs.
    /// </summary>
    public class WeatherObject
    {
        public City City { get; set; }
        public DateTime Update { get; set; }
        public List<Forecast> Forecast { get; set; }
    }

}
