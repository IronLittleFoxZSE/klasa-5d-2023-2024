using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ComboBoxProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private ObservableCollection<string> _listOfItems;
        public ObservableCollection<string> ListOfItems
        {
            get
            {
                return _listOfItems;
            }
            set
            {
                _listOfItems = value;
                OnPropertyChanged(nameof(ListOfItems));
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            ListOfItems = new ObservableCollection<string>();
            ListOfItems.Add("Pozycja bindowania 0");
            ListOfItems.Add("Pozycja bindowania 1");
            ListOfItems.Add("Pozycja bindowania 2");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListOfItems.Add("Pozycja bindowania 11");
            ListOfItems.Add("Pozycja bindowania 12");
            //OnPropertyChanged(nameof(ListOfItems));
        }
    }
}
