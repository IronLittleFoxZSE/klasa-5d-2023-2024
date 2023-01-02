using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UtilitiesWpf;

namespace ClockWpfApp.ViewModels
{
    class StopWatchViewModel : ObserverVM
    {
        private string timeStorage;
        public string TimeStorage
        {
            get { return timeStorage; }
            set 
            { 
                timeStorage = value;
                OnPropertyChanged(nameof(TimeStorage));
            }
        }

        private ICommand startCommand;
        public ICommand StartCommand
        {
            get
            {
                if (startCommand == null)
                    startCommand = new RelayCommand<object>(
                        o =>
                        {
                           
                        }
                        );
                return startCommand;
            }
        }

        private ICommand stopCommand;
        public ICommand StopCommand
        {
            get
            {
                if (stopCommand == null)
                    stopCommand = new RelayCommand<object>(
                        o =>
                        {

                        }
                        );
                return stopCommand;
            }
        }

    }
}
