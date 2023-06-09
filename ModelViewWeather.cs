using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanifApp
{
    /// <summary>
    /// View Model classe du projet.
    /// </summary>
    public class ModelViewWeather : INotifyPropertyChanged
    {
        /// <summary>
        /// Méthode permettant de mettre à jour la Vue lorsqu'une propriété est modifiée.
        /// </summary>
        /// <param name="propertyName"></param>
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Ensemble des propriétés utilisées dans la Vue.
        /// </summary>
        public string City { get => ModelWeather.Forecast != null ? ModelWeather.City.Name : "Fail"; }

        public int TempMin { get => ModelWeather.Forecast != null ? ModelWeather.Forecast.FirstOrDefault().Tmin : Int32.MinValue; }

        public int TempMax { get => ModelWeather.Forecast != null ? ModelWeather.Forecast.FirstOrDefault().Tmax : 100; }

        public double RainProba { get => ModelWeather.Forecast != null ? ModelWeather.Forecast.FirstOrDefault().Probarain : double.NaN; }

        public double Wind { get => ModelWeather.Forecast != null ? ModelWeather.Forecast.FirstOrDefault().Wind10m : 65; }

        

        private WeatherObject _modelWeather;

        public event PropertyChangedEventHandler PropertyChanged;

        private WeatherObject ModelWeather
        {
            get { return _modelWeather ?? (_modelWeather = new WeatherObject()); }
            set
            { 
                _modelWeather = value;
                OnPropertyChanged("City");
                OnPropertyChanged("TempMin");
                OnPropertyChanged("TempMax");
                OnPropertyChanged("RainProba");
                OnPropertyChanged("Wind");
            }
        }

        public ModelViewWeather() 
        {
            Task.Run(() =>
            {
                GetWeatherData();
            }).Wait();
        }

        private async void GetWeatherData()
        {
            try
            {
                ModelWeather = await WeatherService.CallWebAPIAsync();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }  
        }
    }
}
