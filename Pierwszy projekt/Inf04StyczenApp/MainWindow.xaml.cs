using System;
using System.Collections.Generic;
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

namespace Inf04StyczenApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string password;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonGeneratePassword_Click(object sender, RoutedEventArgs e)
        {
            string smallLetters = "qwertyuiopasdfghjklzxcvbnm";
            string bigLeters = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string digit = "1234567890";
            string specialChar = "!@#$%^&*()_+=";

            //int passwordLenght = textBoxPasswordLength.Text;
            if (!int.TryParse(textBoxPasswordLength.Text, out int passwordLenght))
            {
                MessageBox.Show("Nieprawidłowa wartość w długości hasła");
                return;
            }

            bool hasBigLetters = checkBoxHasBigLetters.IsChecked.Value;
            bool hasDigit = checkBoxHasDigit.IsChecked.Value;
            bool hasSpecialChar = checkBoxHasSpecialChar.IsChecked.Value;

            password = "";
            Random random = new Random();

            //wersja 1
            if (hasBigLetters)
            {
                password += bigLeters[random.Next(bigLeters.Length)];
            }
            if (hasDigit)
            {
                password += digit[random.Next(digit.Length)];
            }
            if (hasSpecialChar)
            {
                password += specialChar[random.Next(specialChar.Length)];
            }
            for (int i = password.Length; i < passwordLenght; i++)
            {
                password += smallLetters[random.Next(smallLetters.Length)];
            }
            MessageBox.Show(password);
        }
    }
}
