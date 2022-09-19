using Przelicznik.Database.Context;
using Przelicznik.Database.Entities;
using Przelicznik.Database.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przelicznik
{
    public partial class MainWindow : Form
    {
        private ConverterDbRepository converterDbRepository;


        public MainWindow()
        {
            InitializeComponent();
            converterDbRepository = new ConverterDbRepository();

            List<UnitType> listOfUnitType = converterDbRepository.ReadAllUnitType();
        }

    }
}
