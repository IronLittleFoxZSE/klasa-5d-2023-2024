using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpisOsob.Baza_danych.Model;

namespace SpisOsob.Baza_danych.Context
{
    class MojaBazaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Osoba> Osoby { get; set; }
    }
}
