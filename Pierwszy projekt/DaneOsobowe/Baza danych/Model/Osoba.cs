using System;
using System.Collections.Generic;
using System.Text;

namespace DaneOsobowe.Baza_danych.Model
{
    class Osoba
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }
    }
}
