using System;
using System.ComponentModel;
using System.Windows;

namespace UtilitiesWpf
{
    public class ObserverWindow: Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
