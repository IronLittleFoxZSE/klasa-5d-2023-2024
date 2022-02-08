using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pierwszy_projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!!!!");

            //typ_zmiennej nazwa_zmiennej;
            string imie = "Jan";
            string nazwisko = "Kowalski";

            Console.WriteLine("Nazywam sie " + imie + " " + nazwisko + ".");
            Console.WriteLine("Nazywam sie {0} {1}.",imie, nazwisko);
            Console.WriteLine($"Nazywam sie {imie} hhh {nazwisko}.");

            Console.WriteLine("Prędkość to km\\h");
            Console.WriteLine(@"Prędkość to km\h");

            int a;
            a = 5;
            int b = a;
            b = 6;
            Console.WriteLine("a = " + a);
            Console.WriteLine($"b = {b}");

            Osoba osoba_1 = new Osoba();
            osoba_1.imie = "Jan";
            osoba_1.nazwisko = "Kowalski";
            osoba_1.wiek = 30;

            Osoba osoba_2 = new Osoba();
            osoba_2.imie = "Paweł";
            osoba_2.nazwisko = "Nowak";
            osoba_2.wiek = 18;

            Osoba osoba_3 = osoba_2;

            Osoba osoba_4 = osoba_1;
            osoba_4.imie = "Karol";

            Console.WriteLine("Osoba 1: " + osoba_1.imie + " " 
                            + osoba_1.nazwisko + " " + osoba_1.wiek);
            Console.WriteLine("Osoba 2: " + osoba_2.imie + " " 
                            + osoba_2.nazwisko + " " + osoba_2.wiek);
            Console.WriteLine("Osoba 3: " + osoba_3.imie + " " 
                            + osoba_3.nazwisko + " " + osoba_3.wiek);
            Console.WriteLine("Osoba 4: " + osoba_4.imie + " " 
                            + osoba_4.nazwisko + " " + osoba_4.wiek);


            Console.WriteLine("--------------------------");

            int x;
            //x = 5;
            //Console.WriteLine("X = " + x);
            //Metoda1(x);
            //Console.WriteLine("X = " + x);
            //Metoda1_1(ref x);
            //Console.WriteLine("X = " + x);
            //x = Metoda1_2(x);
            Metoda1_3(out x);

            Osoba o = new Osoba();
            o.imie = "Jan";
            Console.WriteLine("o.imie = " + o.imie);
            Metoda2(o);
            Console.WriteLine("o.imie = " + o.imie);

            Console.ReadLine();
        }

        static void Metoda1(int a)
        {
            Console.WriteLine("Metoda1 a=" + a);
            a++;
            Console.WriteLine("Metoda1 a=" + a);
        }

        static void Metoda1_1(ref int a)
        {
            Console.WriteLine("Metoda1 a=" + a);
            a++;
            Console.WriteLine("Metoda1 a=" + a);
        }

        static int Metoda1_2(int a)
        {
            Console.WriteLine("Metoda1 a=" + a);
            a++;
            Console.WriteLine("Metoda1 a=" + a);
            return a;
        }

        static void Metoda1_3(out int x)
        {
            Console.WriteLine("Podaj liczbe: ");
            string liczbaString = Console.ReadLine();
            x = int.Parse(liczbaString);
        }

        static void Metoda2(Osoba oo)
        {
            Console.WriteLine("Metoda2 oo.imie= " + oo.imie);
            oo.imie = "Paweł";
            Console.WriteLine("Metoda2 oo.imie= " + oo.imie);
        }
    }
}
