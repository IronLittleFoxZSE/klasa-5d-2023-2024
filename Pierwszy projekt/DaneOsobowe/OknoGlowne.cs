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

namespace DaneOsobowe
{
    public partial class OknoGlowne : Form
    {
        private MojaBazaContext bazaDanychContext;

        public OknoGlowne()
        {
            InitializeComponent();
            bazaDanychContext = new MojaBazaContext();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            Osoba osoba = new Osoba();
            osoba.Imie = textBoxImie.Text;
            osoba.Nazwisko = textBoxNazwisko.Text;
            osoba.Wiek = (int)numericUpDownWiek.Value;

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
                .Where(oo => oo.Wiek >= (int) numericUpDownSzukajWiek.Value);

            /*comboBoxWynik.Items.Clear();
            foreach (Osoba osoba in kolekcjaOsob)
            {
                comboBoxWynik.Items.Add(osoba.Nazwisko);
            }

            comboBoxWynik.SelectedIndex = 0;*/

            comboBoxWynik.DataSource = kolekcjaOsob.ToList();
            comboBoxWynik.DisplayMember = "Nazwisko";

        }
    }
}
