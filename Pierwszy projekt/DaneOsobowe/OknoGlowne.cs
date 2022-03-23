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
            osoba.Wiek = (int) numericUpDownWiek.Value;

            bazaDanychContext.Osoby.Add(osoba);
            bazaDanychContext.SaveChanges();
        }
    }
}
