using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ListOfContactsApp
{
    class MainViewModel : BindableObject
    {

        private Contact selectedContact;
        public Contact SelectedContact
        {
            get { return selectedContact; }
            set
            {
                selectedContact = value;
                OnPropertyChanged(nameof(SelectedContact));
            }
        }

        private string smsText;
        public string SmsText
        {
            get { return smsText; }
            set
            {
                smsText = value;
                OnPropertyChanged();
            }
        }

        private ICommand sendSmsCommand;
        public ICommand SendSmsCommand
        {
            get
            {
                if (sendSmsCommand == null)
                    sendSmsCommand = new Command<object>(
                        async o =>
                        {
                            try
                            {
                                string phoneNumber = "";
                                if (SelectedContact != null)
                                    phoneNumber = SelectedContact.Phones[0].PhoneNumber;
                                var message = new SmsMessage(smsText, phoneNumber);
                                await Sms.ComposeAsync(message);
                            }
                            catch (FeatureNotSupportedException ex)
                            {
                                // Sms is not supported on this device.
                            }
                            catch (Exception ex)
                            {
                                // Other error has occurred.
                            }
                        }
                        );
                return sendSmsCommand;
            }
        }


        public ObservableCollection<Contact> CollectionOfContacts { get; set; }

        private ICommand phoneCallCommand;
        public ICommand PhoneCallCommand
        {
            get
            {
                if (phoneCallCommand == null)
                    phoneCallCommand = new Command<Contact>(
                        contact =>
                        {
                            try
                            {
                                PhoneDialer.Open(contact.Phones[0].PhoneNumber);
                            }
                            catch (Exception)
                            {

                            }
                        }
                        );
                return phoneCallCommand;
            }
        }

        public MainViewModel()
        {
            try
            {
                //Contacts.PickContactAsync();
                CollectionOfContacts = new ObservableCollection<Contact>();
                var contacts = Contacts.GetAllAsync().Result;
                if (contacts == null)
                    return;
                foreach (var item in contacts)
                {
                    CollectionOfContacts.Add(item);
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
