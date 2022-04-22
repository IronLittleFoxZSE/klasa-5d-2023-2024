using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjektUczniowie.Baza_danych.Context;

namespace ProjektUczniowie
{
    public partial class OknoGlowne : Form
    {
        private MojaBazaContext bazaContext;

        public OknoGlowne()
        {
            InitializeComponent();

            bazaContext = new MojaBazaContext();
        }

        private void buttonOperacjeDodajKlase_Click(object sender, EventArgs e)
        {

        }
    }
}
