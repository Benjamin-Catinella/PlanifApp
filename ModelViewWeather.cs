using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanifApp
{
    public class ModelViewWeather : INotifyPropertyChanged
    {
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string City { get => ModelWeather.Forecast != null ? ModelWeather.City.Name : "Fail"; }

        public int TempMin { get => ModelWeather.Forecast != null ? ModelWeather.Forecast.FirstOrDefault().Tmin : 0; }

        public int TempMax { get => ModelWeather.Forecast != null ? ModelWeather.Forecast.FirstOrDefault().Tmax : 100; }

        public double RainProba { get => ModelWeather.Forecast != null ? ModelWeather.Forecast.FirstOrDefault().Probarain : 50.5; }

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
