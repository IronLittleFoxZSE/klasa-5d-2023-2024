using LoginWpfApp.Database.Repository;
using LoginWpfApp.Validation;
using LoginWpfApp.Validation.TypesOfValidation;
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
        private string _login;
        public string Login
        {
            get { return _login; }
            set 
            { 
                _login = value;
                OnPropertyChanged(nameof(Login));
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set 
            { 
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set
            { 
                _message = value;
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
                            DatabaseRepository databaseRepository = new DatabaseRepository();

                            Validate validate = new Validate();
                            validate.AddValidator(new Validator<string>(Login, "Login",
                                new List<ISpecyficValidation<string>>()
                                {
                                new ValidateStringEmpty(),
                                new ValidateStringLength(5)
                                }));
                            validate.AddValidator(new Validator<string>(Password, "Hasło",
                                new List<ISpecyficValidation<string>>()
                                {
                                new ValidateStringEmpty(),
                                new ValidateStringLength(8),
                                new ValidateStringRequiredCharacters(new (){'0', '1', '2', '3', '4', '5', '6', '7', '8', '9' })
                                }));
                            validate.AddValidator(new Validator<List<string>>(new List<string>() { Login, Password },
                                "Błąd logowania",
                                new List<ISpecyficValidation<List<string>>>()
                                {
                                    new ValidateMethodTwoParameters<string>(databaseRepository.CheckUserIsRegistered,
                                    "Nie ma takiego konta w systemie")
                                }));


                            if (validate.Validation(out string message))
                            {
                                Message = "OK";
                            }
                            else
                                Message = message;
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
                            DatabaseRepository databaseRepository = new DatabaseRepository();

                            Validate validate = new Validate();
                            validate.AddValidator(new Validator<string>(Login, "Login",
                                new List<ISpecyficValidation<string>>()
                                {
                                new ValidateStringEmpty(),
                                new ValidateStringLength(5)
                                }));
                            validate.AddValidator(new Validator<string>(Password, "Hasło",
                                new List<ISpecyficValidation<string>>()
                                {
                                new ValidateStringEmpty(),
                                new ValidateStringLength(8),
                                new ValidateStringRequiredCharacters(new (){'0', '1', '2', '3', '4', '5', '6', '7', '8', '9' })
                                }));
                            validate.AddValidator(new Validator<List<string>>(new List<string>() { Login},
                                "Błąd logowania",
                                new List<ISpecyficValidation<List<string>>>()
                                {
                                    new ValidateMethodOneParameter<string>(databaseRepository.CheckUserIsNotRegistered,
                                    "Jest już taki uzytkownik")
                                }));


                            if (validate.Validation(out string message))
                            {
                                databaseRepository.AddUser(Login, Password);
                                Message = "Użytkownik został dodany do bazy";
                            }
                            else
                                Message = message;
                        }
                        );
                }
                return _registrationCommand;
            }
        }

    }
}
