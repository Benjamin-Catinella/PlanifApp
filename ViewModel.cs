using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            IncrementCounterCommand = new RelayCommand(IncrementCounter);
        }
        private string _btnText = "Commander";
        public string BtnText
        {
            get { return _btnText; }
            set
            {
                _btnText = value;
                OnPropertyChanged("BtnText");
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
        public ICommand IncrementCounterCommand { get; }
        private void IncrementCounter() => Counter++;
    }
}