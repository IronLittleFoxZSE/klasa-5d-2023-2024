using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using UtilitiesWpf;

namespace PhotoViewerWpfApp
{
    class PhotoViewerViewModel : ObserverVM
    {
        private string imagePath;
        public string ImagePath
        {
            get { return imagePath; }
            set
            {
                imagePath = value;
                OnPropertyChanged(nameof(ImagePath));
            }
        }

        private ICommand loadFromFileCommand;
        public ICommand LoadFromFileCommand
        {
            get
            {
                if (loadFromFileCommand == null)
                    loadFromFileCommand = new RelayCommand<object>(
                        x =>
                        {
                            OpenFileDialog openFileDialog = new OpenFileDialog();
                            openFileDialog.Filter = "Obrazy JPG|*.jpg;*.jpeg|Obrazy PNG|*.png";
                            if (openFileDialog.ShowDialog() == true)
                            {
                                ImagePath = openFileDialog.FileName;
                            }
                            else
                            {
                                MessageBox.Show("Nie wybrano pliku");
                            }
                        }
                        );
                return loadFromFileCommand;
            }
        }

    }
}
