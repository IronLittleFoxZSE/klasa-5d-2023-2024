using LoginWpfApp.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWpfApp.Database.Context
{
    //add-migration FirstMigration -OutputDir Database\Migrations -Project LoginWpfApp -StartupProject LoginWpfApp
    class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"filename=Database\baza.db");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<RegisteredUser> RegisteredUsers { get; set; }
    }
}
