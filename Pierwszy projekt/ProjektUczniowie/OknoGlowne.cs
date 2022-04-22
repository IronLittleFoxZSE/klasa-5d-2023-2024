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
using ProjektUczniowie.Baza_danych.Model;

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
            OknoDodajKlase oknoDodajKlase = new OknoDodajKlase();
            if (oknoDodajKlase.ShowDialog() == DialogResult.OK)
            {
                Klasa nowaKlasa = new Klasa()
                {
                    NazwaKlasy = oknoDodajKlase.NazwaKlasy
                };

                bazaContext.Klasy.Add(nowaKlasa);
                bazaContext.SaveChanges();
            }

        }
    }
}
