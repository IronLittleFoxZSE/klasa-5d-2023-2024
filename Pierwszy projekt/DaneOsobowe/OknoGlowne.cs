using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DaneOsobowe.Baza_danych.Context;
using DaneOsobowe.Baza_danych.Model;
using Microsoft.EntityFrameworkCore;

namespace DaneOsobowe
{
    public partial class OknoGlowne : Form
    {
        private MojaBazaContext bazaDanychContext;

        public OknoGlowne()
        {
            InitializeComponent();

            bazaDanychContext = new MojaBazaContext();
            dataGridViewLista.AutoGenerateColumns = false;

            //DodanieAdresowDoBazy();
            //PowiazOsobyAdresy();
        }

        private void PowiazOsobyAdresy()
        {
            var kolekcjaOsob = bazaDanychContext.Osoby;
            foreach (Osoba osoba in kolekcjaOsob)
            {
                osoba.AdresId = 2;
            }

            bazaDanychContext.SaveChanges();
        }

        private void DodanieAdresowDoBazy()
        {
            Adres adres = new Adres();
            adres.Miasto = "Kielce";
            adres.Ulica = "Majowa";
            adres.NrDomu = "5";
            bazaDanychContext.Adresy.Add(adres);

            adres = new Adres()
            {
                Miasto = "Morawica",
                Ulica = "Leśna",
                NrDomu = "123"
            };
            bazaDanychContext.Adresy.Add(adres);

            bazaDanychContext.SaveChanges();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            Osoba osoba = new Osoba();
            osoba.Imie = textBoxImie.Text;
            osoba.Nazwisko = textBoxNazwisko.Text;
            osoba.Wiek = (int)numericUpDownWiek.Value;

            /*osoba = new Osoba()
            {
                Imie = textBoxImie.Text,
                Nazwisko = textBoxNazwisko.Text,
                Wiek = (int)numericUpDownWiek.Value
            };*/

            bazaDanychContext.Osoby.Add(osoba);
            bazaDanychContext.SaveChanges();
        }

        private void buttonOdczytajWiersz_Click(object sender, EventArgs e)
        {
            /*
             select top 1 *
               from Osoby
              where id = 1
             */
            //Osoba osoba = bazaDanychContext.Osoby.Where((Osoba o) => /*return*/ o.Id == 1).FirstOrDefault();
            Osoba osoba = bazaDanychContext.Osoby.FirstOrDefault(o => o.Id == (int)numericUpDownSzukajId.Value);

            if (osoba != null)
            {
                textBoxImieRead.Text = osoba.Imie;
                textBoxNazwiskoRead.Text = osoba.Nazwisko;
                numericUpDownWiekRead.Value = osoba.Wiek;
            }
            else
            {
                MessageBox.Show("Brak wiersza w bazie");
            }



            //var kolekcja = System.Linq.Queryable.Where(bazaDanychContext.Osoby, funkcjaSprawdzajaca);
            //var kolekcja_2 = TestWhere(bazaDanychContext.Osoby, funkcjaSprawdzajaca);
        }

        private bool funkcjaSprawdzajaca(Osoba o)
        {
            /*if (o.Id == 1)
                return true;

            return false;*/
            return o.Id == 1;
        }

        private List<Osoba> TestWhere(IEnumerable<Osoba> kolekcjaWejsciowa, Func<Osoba, bool> predicate)
        {
            List<Osoba> kolekcjaWyjsciowa = new List<Osoba>();
            foreach (Osoba osoba in kolekcjaWejsciowa)
            {
                //if (osoba.Id == 1)
                if (predicate(osoba) == true)
                {
                    kolekcjaWyjsciowa.Add(osoba);
                }
            }

            return kolekcjaWyjsciowa;
        }

        private void buttonSzukajWiek_Click(object sender, EventArgs e)
        {
            /*
             select *
               from Osoby o
              where o.wiek >= (int)numericUpDownSzukajWiek.Value

             */

            var kolekcjaOsob = bazaDanychContext.Osoby
                .Where(oo => oo.Wiek >= (int)numericUpDownSzukajWiek.Value);

            /*comboBoxWynik.Items.Clear();
            foreach (Osoba osoba in kolekcjaOsob)
            {
                comboBoxWynik.Items.Add(osoba.Nazwisko);
            }

            comboBoxWynik.SelectedIndex = 0;*/

            comboBoxWynik.DataSource = kolekcjaOsob.ToList();
            comboBoxWynik.DisplayMember = "Nazwisko";

        }

        private void buttonSzukaj_Click(object sender, EventArgs e)
        {
            /*
             select *
               from Osoby o
              where o.wiek >= (int)numericUpDownSzukajWiek.Value
            order by o.wiek desc, o.imie

             */

            var kolekcjaOsob = bazaDanychContext.Osoby
                .Where(oo => oo.Wiek >= (int)numericUpDownSzukajWiek.Value)
                //.OrderBy(o=> o.Wiek); // sortowanie rosnąco
                .OrderByDescending(o => o.Wiek) // sortowanie malejąco
                .ThenBy(o => o.Imie);


            dataGridViewLista.DataSource = kolekcjaOsob.ToList();

        }

        private void buttonSzukajPelnoletnie_Click(object sender, EventArgs e)
        {
            /*
             select o.Imie.
                    o.Nazwisko,
                    o.Wiek, 
                    o.wiek >= 18 as Pelnoletnosc,
                    a.Miasto,
                    a.Ulica + ' ' + a.NrDomu as Ulica
               from Osoby o
               join Adresy a on a.Id = o.AdresId
              where o.wiek >= (int)numericUpDownSzukajWiek.Value
            order by o.wiek desc, o.imie

             */

            var kolekcjaOsob = bazaDanychContext.Osoby
                .Include(o => o.Adres)
                .Where(oo => oo.Wiek >= (int)numericUpDownSzukajWiek.Value)
                //.OrderBy(o=> o.Wiek); // sortowanie rosnąco
                .OrderByDescending(o => o.Wiek) // sortowanie malejąco
                .ThenBy(o => o.Imie)
                .Select(o => new OsobaNaLiscie()
                {
                    Imie = o.Imie,
                    Nazwisko = o.Nazwisko,
                    Wiek = o.Wiek,
                    Pelnoletnosc = o.Wiek >= 18,
                    Miasto = o.Adres.Miasto,
                    Ulica = o.Adres.Ulica + " " + o.Adres.NrDomu
                });

            dataGridViewLista.DataSource = kolekcjaOsob.ToList();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            /*
             update Osoby
                set Nazwisko = textBoxNazwiskoUpdate.Text
              where Id = numericUpDownId.Value

            select *
              from Osoby
             where Id = numericUpDownId.Value
             */

            Osoba szukanaOsoba = bazaDanychContext.Osoby
                .FirstOrDefault(o => o.Id == (int)numericUpDownId.Value);

            if (szukanaOsoba != null)
            {
                szukanaOsoba.Nazwisko = textBoxNazwiskoUpdate.Text;

                bazaDanychContext.SaveChanges();
            }
            else
            {
                MessageBox.Show("Nie znaleziono w bazie osoby");
            }

            return;
            /*
             update Osoby
                set Nazwisko = textBoxNazwiskoUpdate.Text
              where Id > numericUpDownId.Value
            */

            var szukanaOsoby = bazaDanychContext.Osoby
                .Where(o => o.Id > (int)numericUpDownId.Value);

            foreach (Osoba osoba in szukanaOsoby)
            {
                osoba.Nazwisko = textBoxNazwiskoUpdate.Text;
            }

            bazaDanychContext.SaveChanges();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            /*
             delete from Osoby
              where id == numericUpDownDeleteId.value
             */

            Osoba osobaDoSkasowania = bazaDanychContext.Osoby
                .FirstOrDefault(o => o.Id == (int)numericUpDownDeleteId.Value);
            if (osobaDoSkasowania != null)
            {
                bazaDanychContext.Osoby.Remove(osobaDoSkasowania);
                bazaDanychContext.SaveChanges();
            }
            else
            {
                MessageBox.Show("Nie znaleziono w bazie osoby");
            }
        }
    }
}
