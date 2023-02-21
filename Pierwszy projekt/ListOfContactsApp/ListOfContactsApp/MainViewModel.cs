using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ListOfContactsApp
{
    class MainViewModel
    {
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
