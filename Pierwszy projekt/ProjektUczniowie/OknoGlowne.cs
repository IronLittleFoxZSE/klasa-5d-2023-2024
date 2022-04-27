using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
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
            dataGridViewLista.AutoGenerateColumns = false;
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
                    Imie = oknoSzczegolyUczen.Imie,
                    Nazwisko = oknoSzczegolyUczen.Nazwisko,
                    RokUrodzenia = oknoSzczegolyUczen.RokUrodzenia,
                    KlasaId = oknoSzczegolyUczen.WybranaKlasa.Id
                };
                bazaContext.Uczniowie.Add(nowyUczen);
                bazaContext.SaveChanges();
            }
        }

        private void buttonFiltrySzukaj_Click(object sender, EventArgs e)
        {
            /*
             select u.Imie,
                    u.Nazwisko,
                    u.RokUrodzenia,
                    k.NazwaKlasy
               from Uczniowie u
               join Klasy k on k.Id = u.KlasaId
              where k.Id = comboBoxFiltryKlasa.SelectedItem.Id
             */

            var listaDocelowa = bazaContext.Uczniowie
                .Include(u => u.Klasa)
                .Where(u=> u.Klasa.Id == (comboBoxFiltryKlasa.SelectedItem as Klasa).Id)
                .Select(u => new UczenGrid()
                {
                    Imie = u.Imie,
                    Nazwisko = u.Nazwisko,
                    RokUrodzenia = u.RokUrodzenia,
                    NazwaKlasy = u.Klasa.NazwaKlasy
                });


            dataGridViewLista.DataSource = listaDocelowa.ToList();
        }
    }
}
