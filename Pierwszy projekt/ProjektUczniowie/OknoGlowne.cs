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
              where 1 = 1
                and (comboBoxFiltryKlasa.SelectedItem.Id == -1
                    or k.Id = comboBoxFiltryKlasa.SelectedItem.Id)
                and (string.IsNullOrEmpty(textBoxFiltryImie.Text)
                    --or u.Imie = textBoxFiltryImie.Text
                     or u.Imie like '%' + textBoxFiltryImie.Text + '%'
            )
             */

            int wybraneIdKlasy = (comboBoxFiltryKlasa.SelectedItem as Klasa).Id;

            var listaDocelowa = bazaContext.Uczniowie
                .Include(u => u.Klasa)
                .Where(u=> wybraneIdKlasy == -1 || u.Klasa.Id == wybraneIdKlasy)
                .Where(u=> string.IsNullOrEmpty(textBoxFiltryImie.Text.Trim())
                               || u.Imie.Contains(textBoxFiltryImie.Text))
                .Where(u => string.IsNullOrEmpty(textBoxFiltryNazwisko.Text.Trim())
                            || u.Nazwisko.Contains(textBoxFiltryNazwisko.Text))
                .Where(u => string.IsNullOrEmpty(numericUpDownFiltryRok.Text.Trim())
                            || u.RokUrodzenia == (int)numericUpDownFiltryRok.Value)
                .Select(u => new UczenGrid()
                {
                    Id = u.Id,
                    Imie = u.Imie,
                    Nazwisko = u.Nazwisko,
                    RokUrodzenia = u.RokUrodzenia,
                    NazwaKlasy = u.Klasa.NazwaKlasy,
                    Klasa = u.Klasa
                });


            dataGridViewLista.DataSource = listaDocelowa.ToList();
        }

        private void buttonOperacjeUsun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy chesz usunąć aktualny rekord?",
                    "Usuwanie",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                UczenGrid aktualnyWiersz = dataGridViewLista.CurrentRow
                                           ?.DataBoundItem as UczenGrid;
                if (aktualnyWiersz != null)
                {
                    /*
                     select *
                       from Uczniowie u
                      where u.Id = aktualnyWiersz.Id
                     
                     */
                    Uczen szukanyUczen = bazaContext.Uczniowie.Find(aktualnyWiersz.Id);
                    if (szukanyUczen != null)
                    {
                        bazaContext.Uczniowie.Remove(szukanyUczen);
                        bazaContext.SaveChanges();
                        MessageBox.Show("Kasowanie zakończone sukcesem");
                        buttonFiltrySzukaj.PerformClick();
                    }
                }
            }
        }

        private void buttonOperacjeEdytuj_Click(object sender, EventArgs e)
        {
            OknoSzczegolyUczen oknoSzczegolyUczen = new OknoSzczegolyUczen();
            oknoSzczegolyUczen.OpisOkna = "Edytuj ucznia";
            oknoSzczegolyUczen.OpisPrzyciskuOk = "Zapisz zmiany";

            List<Klasa> listaDlaOkna = listaKlas.ToList();
            listaDlaOkna.RemoveAt(0);

            oknoSzczegolyUczen.ListaKlas = listaDlaOkna;

            UczenGrid aktualnyWiersz = dataGridViewLista.CurrentRow?.DataBoundItem as UczenGrid;

            if (aktualnyWiersz == null)
                return;

            oknoSzczegolyUczen.Imie = aktualnyWiersz.Imie;
            oknoSzczegolyUczen.Nazwisko = aktualnyWiersz.Nazwisko;
            oknoSzczegolyUczen.RokUrodzenia = aktualnyWiersz.RokUrodzenia;
            oknoSzczegolyUczen.WybranaKlasa = aktualnyWiersz.Klasa;

            if (oknoSzczegolyUczen.ShowDialog() == DialogResult.OK)
            {
                Uczen uczenDoModyfikacji = bazaContext.Uczniowie.Find(aktualnyWiersz.Id);
                if (uczenDoModyfikacji != null)
                {
                    uczenDoModyfikacji.Imie = oknoSzczegolyUczen.Imie;
                    uczenDoModyfikacji.Nazwisko = oknoSzczegolyUczen.Nazwisko;
                    uczenDoModyfikacji.RokUrodzenia = oknoSzczegolyUczen.RokUrodzenia;
                    uczenDoModyfikacji.KlasaId = oknoSzczegolyUczen.WybranaKlasa.Id;
                    bazaContext.SaveChanges();

                    aktualnyWiersz.Imie = oknoSzczegolyUczen.Imie;
                    aktualnyWiersz.Nazwisko = oknoSzczegolyUczen.Nazwisko;
                    aktualnyWiersz.RokUrodzenia = oknoSzczegolyUczen.RokUrodzenia;
                    aktualnyWiersz.Klasa = oknoSzczegolyUczen.WybranaKlasa;
                    dataGridViewLista.Refresh();
                }
            }
        }
    }
}
