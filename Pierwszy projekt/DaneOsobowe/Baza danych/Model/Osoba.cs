using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DaneOsobowe.Baza_danych.Model
{
    class Osoba
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(15)]
        public string Imie { get; set; }
        [Required]
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }

        public int? AdresId { get; set; }
        public Adres Adres { get; set; }
    }
}
