using System;

namespace Statyczność
{
   

    class Osoba
    {
        //pola i metody klasy
        public string imie;

        public static int ileUtworzonoObiektowTejKlasy = 0;

        public Osoba()
        {
            ileUtworzonoObiektowTejKlasy++;
        }

        public static void WyswietlInfoStatystyczne()
        {
            Console.WriteLine("Utworzono :" + ileUtworzonoObiektowTejKlasy);
            //imie = "ala";
        }
    }

    class Program
    {



        static void Main(string[] args)
        {
            Osoba os = new Osoba();
            os = new Osoba();
            os = new Osoba();
            os = new Osoba();
            Console.WriteLine("Utworzono :" + Osoba.ileUtworzonoObiektowTejKlasy);
            Osoba.WyswietlInfoStatystyczne();
            Console.ReadLine();

            double x = Math.Sqrt(2);
            var dd= Math.PI;
        }
    }
}
