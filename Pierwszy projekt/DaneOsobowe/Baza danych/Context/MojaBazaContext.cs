using System;
using System.Collections.Generic;
using System.Text;
using DaneOsobowe.Baza_danych.Model;
using Microsoft.EntityFrameworkCore;

namespace DaneOsobowe.Baza_danych.Context
{
    class MojaBazaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=bazaDanych3d.db");

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Osoba> Osoby { get; set; }
    }
}
