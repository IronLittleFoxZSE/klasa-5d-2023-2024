﻿using System;
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

namespace BindingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBoxValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBlokValue.Text = textBoxValue.Text;
            buttonValue.Content = textBoxValue.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(textBoxCom.Text);
        }
    }
}
