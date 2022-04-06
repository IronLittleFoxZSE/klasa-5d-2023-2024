using System;
using System.Collections.Generic;
using System.Text;

namespace DaneOsobowe.Baza_danych.Model
{
    class Adres
    {
        public int Id { get; set; }
        public string Ulica { get; set; }
        public string NrDomu { get; set; }
        public string Miasto { get; set; }
    }
}
