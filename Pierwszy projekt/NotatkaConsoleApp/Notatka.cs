using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotatkaConsoleApp
{
    class Notatka
    {
        public static int liczbaNotatek = 0;
        private int id;
        protected string tytul;
        protected string tresc;

        public Notatka(string tytul, string tresc)
        {
            liczbaNotatek++;
            id = liczbaNotatek;
            this.tytul = tytul;
            this.tresc = tresc;
        }

        public void WyswietlNotatke()
        {
            Console.WriteLine("Tytuł: " + tytul);
            Console.WriteLine($"Treść: {tresc}");
        }

        public void Diagnostyczna()
        {
            Console.WriteLine($"{liczbaNotatek};{id};{tytul};{tresc}");
        }
    }
}
