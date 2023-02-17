using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace MyTaskApp
{
    class MainViewModel : BindableObject
    {
        private int fieldName;
        public int PropertiesName
        {
            get { return fieldName; }
            set
            {
                fieldName = value;
                OnPropertyChanged();
            }
        }

        private ICommand _setOnCommand;
        public ICommand SetOnCommand
        {
            get
            {
                if (_setOnCommand == null)
                    _setOnCommand = new Command<object>(
                        async o =>
                        {
                            try
                            {
                                // Turn On
                                await Flashlight.TurnOnAsync();

                            }
                            catch (FeatureNotSupportedException fnsEx)
                            {
                                // Handle not supported on device exception
                            }
                            catch (PermissionException pEx)
                            {
                                // Handle permission exception
                            }
                            catch (Exception ex)
                            {
                                // Unable to turn on/off flashlight
                            }
                        }
                        );
                return _setOnCommand;
            }
        }

        private ICommand _setOffCommand;
        public ICommand SetOffCommand
        {
            get
            {
                if (_setOffCommand == null)
                    _setOffCommand = new Command<object>(
                        async o =>
                        {
                            try
                            {
                                // Turn Off
                                await Flashlight.TurnOffAsync();
                            }
                            catch (FeatureNotSupportedException fnsEx)
                            {
                                // Handle not supported on device exception
                            }
                            catch (PermissionException pEx)
                            {
                                // Handle permission exception
                            }
                            catch (Exception ex)
                            {
                                // Unable to turn on/off flashlight
                            }
                        }
                        );
                return _setOffCommand;
            }
        }
    }
}
