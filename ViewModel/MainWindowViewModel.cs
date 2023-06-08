using PlanifApp.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace PlanifApp.ViewModel
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        private string _boundText;
        private int _boundValue = 0;
        public event PropertyChangedEventHandler PropertyChanged;
        public string BoundText
        {
            get { return _boundText; }
            set
            {
                _boundText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BoundText"));
            }
        }
        public int BoundValue
        {
            get { return _boundValue; }
            set
            {
                _boundValue = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BoundValue"));
            }
        }

        public ICommand PlusButtonCommand { get; set; }
        public ICommand MinusButtonCommand { get; set; }

        public MainWindowViewModel()
        {
            PlusButtonCommand = new RelayCommand(o => MainPlusButtonClick("PlusButtonCommand"));
            MinusButtonCommand = new RelayCommand(o => MainMinusButtonClick("MinusButtonCommand"));
        }

        private void MainPlusButtonClick(object sender)
        {
            _boundValue++;
        }
        private void MainMinusButtonClick(object sender)
        {
            _boundValue--;
        }
    }
}
