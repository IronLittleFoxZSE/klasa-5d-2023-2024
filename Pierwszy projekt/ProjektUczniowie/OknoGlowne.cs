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
        private List<Klasa> listaKlas;

        public OknoGlowne()
        {
            InitializeComponent();

            bazaContext = new MojaBazaContext();
            ZaladujListeKlas();
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
                ZaladujListeKlas();
            }
        }

        private void ZaladujListeKlas()
        {
            listaKlas = bazaContext.Klasy.ToList();
            listaKlas.Insert(0, new Klasa()
                {
                    Id = -1,
                    NazwaKlasy = "<wszystkie>"
                });
            comboBoxFiltryKlasa.DataSource = listaKlas;
            comboBoxFiltryKlasa.DisplayMember = "NazwaKlasy";
        }

        private void buttonOperacjeDodaj_Click(object sender, EventArgs e)
        {
            OknoSzczegolyUczen oknoSzczegolyUczen = new OknoSzczegolyUczen();
            oknoSzczegolyUczen.OpisOkna = "Dodaj ucznia";
            oknoSzczegolyUczen.OpisPrzyciskuOk = "Dodaj";

            List<Klasa> listaDlaOkna = listaKlas.ToList();
            listaDlaOkna.RemoveAt(0);

            oknoSzczegolyUczen.ListaKlas = listaDlaOkna;
            if (oknoSzczegolyUczen.ShowDialog() == DialogResult.OK)
            {
                Uczen nowyUczen = new Uczen()
                {

                };
                bazaContext.Uczniowie.Add(nowyUczen);
                bazaContext.SaveChanges();
            }
        }
    }
}
