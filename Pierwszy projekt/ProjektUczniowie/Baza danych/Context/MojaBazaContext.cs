using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjektUczniowie.Baza_danych.Model;

namespace ProjektUczniowie.Baza_danych.Context
{
    class MojaBazaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite("FileName=projektUczniowieBaza3d.db");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Uczen> Uczniowie { get; set; }
        public DbSet<Klasa> Klasy { get; set; }
    }
}
