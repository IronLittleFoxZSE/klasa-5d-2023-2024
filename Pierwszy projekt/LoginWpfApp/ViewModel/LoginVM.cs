using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UtilitiesWpf;

namespace LoginWpfApp.ViewModel
{
    class LoginVM : ObserverVM
    {
        private string login;
        public string Login
        {
            get { return login; }
            set 
            { 
                login = value;
                OnPropertyChanged(nameof(Login));
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set 
            { 
                password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        private string message;
        public string Message
        {
            get { return message; }
            set
            { 
                message = value;
                OnPropertyChanged(nameof(Message));
            }
        }

        private ICommand _loginCommand;
        public ICommand LoginCommand
        {
            get 
            { 
                if (_loginCommand == null)
                {
                    _loginCommand = new RelayCommand<object>(
                        (o)=>
                        {

                        }
                        );
                }
                return _loginCommand; 
            }
        }

        private ICommand _registrationCommand;
        public ICommand RegistrationCommand
        {
            get
            {
                if (_registrationCommand == null)
                {
                    _registrationCommand = new RelayCommand<object>(
                        (o) =>
                        {

                        }
                        );
                }
                return _registrationCommand;
            }
        }

    }
}
