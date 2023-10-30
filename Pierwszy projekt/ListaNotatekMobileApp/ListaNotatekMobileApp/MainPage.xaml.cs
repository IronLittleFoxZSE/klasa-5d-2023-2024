using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ListaNotatekMobileApp
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<string> simpleTextNotesCollection;
        public ObservableCollection<string> SimpleTextNotesCollection
        {
            get { return simpleTextNotesCollection; }
            set
            {
                simpleTextNotesCollection = value;
                OnPropertyChanged(nameof(SimpleTextNotesCollection));
            }
        }

        private ICommand addNoteCommand;
        public ICommand AddNoteCommand
        {
            get
            {
                if (addNoteCommand == null)
                    addNoteCommand = new Command<object>(
                        o =>
                        {
                            SimpleTextNotesCollection.Add(entryNewNote.Text);
                        }
                        );
                return addNoteCommand;
            }
        }

        public MainPage()
        {
            SimpleTextNotesCollection = new ObservableCollection<string>();
            SimpleTextNotesCollection.Add("Zakupy: chleb, masło, ser");
            SimpleTextNotesCollection.Add("Do zrobienia: obiad, umyć podłogi");
            SimpleTextNotesCollection.Add("weekend: kino, spacer z psem");
            InitializeComponent();
           
            
        }

        
    }
}
