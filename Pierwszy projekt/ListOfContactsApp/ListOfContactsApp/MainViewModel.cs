using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Essentials;

namespace ListOfContactsApp
{
    class MainViewModel
    {
        public ObservableCollection<Contact> CollectionOfContacts { get; set; }

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
