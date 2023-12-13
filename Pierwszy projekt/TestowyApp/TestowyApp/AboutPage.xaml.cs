using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestowyApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        public AboutPage(string text)
        {
            InitializeComponent();
            ourLabel.Text = text;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}