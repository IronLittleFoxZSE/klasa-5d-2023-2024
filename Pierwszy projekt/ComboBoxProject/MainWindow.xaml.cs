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

        public List<OwnColor> ListOfOwnColors { get; set; }

        public MainWindow()
        {
            ListOfOwnColors = new List<OwnColor>();
            ListOfOwnColors.Add(new OwnColor()
            {
                NameOfColor_Pol = "Zielony",
                NameOfColor_Eng = "Green",
                OwnOrientation = Orientation.Horizontal
            });

            ListOfOwnColors.Add(new OwnColor()
            {
                NameOfColor_Pol = "Złoty",
                NameOfColor_Eng = "Gold",
                OwnOrientation = Orientation.Vertical
            });
            ListOfOwnColors.Add(new OwnColor()
            {
                NameOfColor_Pol = "Czerwony",
                NameOfColor_Eng = "Red",
                OwnOrientation = Orientation.Horizontal
            });

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
