using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PlanifApp
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public ViewModel()
        {
            IncrementCounterCommand = new RelayCommand<object>(o => IncrementCounter(), o => true);
            DecreaseCounterCommand = new RelayCommand<object>(o => DecreaseCounter(), o => true);
        }

        private string _btnIncrease = "+";
        public string BtnIncrease
        {
            get { return _btnIncrease; }
            set
            {
                _btnIncrease = value;
                OnPropertyChanged("BtnIncrease");
            }
        }

        private string _btnDecrease = "-";
        public string BtnDecrease
        {
            get { return _btnDecrease; }
            set
            {
                _btnDecrease = value;
                OnPropertyChanged("BtnDecrease");
            }
        }

        private int _counter = 42;
        public int Counter
        {
            get => _counter;
            private set
            {
                _counter = value;
                OnPropertyChanged("Counter");
            }
        }
        public ICommand IncrementCounterCommand { get; private set;}
        private void IncrementCounter() => Counter++;

        public ICommand DecreaseCounterCommand { get; private set; }
        private void DecreaseCounter() => Counter--;
    }
}