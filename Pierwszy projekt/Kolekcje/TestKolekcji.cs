using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Kolekcje
{
    class Osoba
    {
        public string imie, nazwisko;
        public byte wiek, waga;

        public Osoba(string i, string n, byte w)
        {
            imie = i;
            nazwisko = n;
            wiek = w;
        }
    }


    class TestKolekcji
    {
        public void SortujTablice(int[] tablica)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < tablica.Length - 1; j++)
                {
                    if (tablica[j] > tablica[j + 1])
                    {
                        int tmp = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = tmp;
                    }
                }
            }
        }

        public void SortujTabliceMalejaco(int[] tablica)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < tablica.Length - 1; j++)
                {
                    if (tablica[j] < tablica[j + 1])
                    {
                        int tmp = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = tmp;
                    }
                }
            }
        }

        public void SortujTablice(Osoba[] tablica)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < tablica.Length - 1; j++)
                {
                    if (tablica[j].wiek > tablica[j + 1].wiek)
                    {
                        Osoba tmp = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = tmp;
                    }
                }
            }
        }

        public void SortujTabliceMalejaco(Osoba[] tablica)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < tablica.Length - 1; j++)
                {
                    if (tablica[j].wiek < tablica[j + 1].wiek)
                    {
                        Osoba tmp = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = tmp;
                    }
                }
            }
        }

        public void SortujTablice_Rosnaco_Imie(Osoba[] tablica)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < tablica.Length - 1; j++)
                {
                    //if (tablica[j].wiek < tablica[j + 1].wiek)
                    if (string.Compare(tablica[j].imie, tablica[j + 1].imie) > 0)
                    {
                        Osoba tmp = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = tmp;
                    }
                }
            }
        }

        public void SortujTablice_Malejaco_Imie(Osoba[] tablica)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < tablica.Length - 1; j++)
                {
                    //if (tablica[j].wiek < tablica[j + 1].wiek)
                    if (string.Compare(tablica[j].imie, tablica[j + 1].imie) < 0)
                    {
                        Osoba tmp = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = tmp;
                    }
                }
            }
        }

        public void SortujTablice(Osoba[] tablica, Func<Osoba, Osoba, bool> delegataPorownanie)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < tablica.Length - 1; j++)
                {
                    if (delegataPorownanie(tablica[j], tablica[j + 1]))
                    {
                        Osoba tmp = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = tmp;
                    }
                }
            }
        }

        public void SortujTablice(int[] tablica, Func<int, int, bool> delegataPorownanie)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < tablica.Length - 1; j++)
                {
                    if (delegataPorownanie(tablica[j], tablica[j + 1]))
                    {
                        int tmp = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = tmp;
                    }
                }
            }
        }

        public void Sortuj<T>(T[] tablica, Func<T, T, bool> delegataPorownania)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < tablica.Length - 1; j++)
                {
                    if (delegataPorownania(tablica[j], tablica[j + 1]))
                    {
                        T tmp = tablica[j];
                        tablica[j] = tablica[j + 1];
                        tablica[j + 1] = tmp;
                    }
                }
            }
        }

        public void TestTablic()
        {
            //c++
            //typ nazwa[rozmiar];
            //nazwa[indeks] = wartosc;

            //nagłówek metody
            //typZwracany nazwaMetody(typ nazwa[], int rozmiar)

            //C#
            //typ[] nazwa = new typ[rozmiar];

            int rozmiar = 5; //int.Parse(Console.ReadLine());
            int[] tablicaLiczbCalkowitych = new int[rozmiar];

            //Console.Write(tablicaLiczbCalkowitych[0]);

            tablicaLiczbCalkowitych[0] = 7;
            tablicaLiczbCalkowitych[1] = 3;
            tablicaLiczbCalkowitych[2] = 2;
            tablicaLiczbCalkowitych[3] = 6;
            tablicaLiczbCalkowitych[4] = 5;

            /*int[] tmpTablica = new int[rozmiar + 1];

            for (int i = 0; i < tablicaLiczbCalkowitych.Length; i++)
                tmpTablica[i] = tablicaLiczbCalkowitych[i];

            tablicaLiczbCalkowitych = tmpTablica;
            */

            for (int i = 0; i < tablicaLiczbCalkowitych.Length; i++)
                Console.Write(tablicaLiczbCalkowitych[i] + ", ");
            Console.WriteLine();

            //SORTOWANIE
            SortujTablice(tablicaLiczbCalkowitych, (x, y) => x > y);
            SortujTablice(tablicaLiczbCalkowitych, (x, y) => x < y);
            //Sortuj(tablicaLiczbCalkowitych);



            //Sortuj<int>(tablicaLiczbCalkowitych, (x, y) => x > y);
            Sortuj(tablicaLiczbCalkowitych, (x, y) => x > y);
            //Sortuj<int>(tablicaLiczbCalkowitych, (x, y) => x < y);

            foreach (int elementTablicy in tablicaLiczbCalkowitych)
            {
                Console.Write(elementTablicy + ", ");
            }
            Console.WriteLine();
        }

        public void Test_tablic_z_obiektami()
        {
            Osoba[] tablicaOsob = new Osoba[3];

            //Console.Write(tablicaOsob[0].imie);

            tablicaOsob[0] = new Osoba("Jan", "Kowalski", 20);
            tablicaOsob[1] = new Osoba("Paweł", "Nowak", 15);
            tablicaOsob[2] = new Osoba("Karol", "Krawczyk", 18);

            foreach (Osoba osoba in tablicaOsob)
            {
                Console.WriteLine("Imie: " + osoba.imie);
                Console.WriteLine("Nazwisko: " + osoba.nazwisko);
                Console.WriteLine("Wiek: " + osoba.wiek);
                Console.WriteLine("-----------------------------------");
            }

            SortujTablice(tablicaOsob, PorownajOsobaRosnacoWiek);
            SortujTablice(tablicaOsob, (o1, o2) => o1.wiek > o2.wiek);

            SortujTablice(tablicaOsob, PorownajOsobaMalejacoWiek);
            SortujTablice(tablicaOsob, (o1, o2) => o1.wiek < o2.wiek);

            SortujTablice(tablicaOsob, (o1, o2) => string.Compare(o1.imie, o2.imie) > 0);
            SortujTablice(tablicaOsob, (o1, o2) => string.Compare(o1.imie, o2.imie) < 0);

            SortujTablice(tablicaOsob, (o1, o2) => /*return*/ string.Compare(o1.nazwisko, o2.nazwisko) > 0);
            SortujTablice(tablicaOsob, (o1, o2) => string.Compare(o1.nazwisko, o2.nazwisko) < 0);

            Sortuj<Osoba>(tablicaOsob, (o1, o2) => o1.wiek > o2.wiek);
            Sortuj(tablicaOsob, (o1, o2) => o1.wiek > o2.wiek);

            Console.WriteLine("Tablica po posortowaniu");
            Console.WriteLine();
            foreach (Osoba osoba in tablicaOsob)
            {
                Console.WriteLine("Imie: " + osoba.imie);
                Console.WriteLine("Nazwisko: " + osoba.nazwisko);
                Console.WriteLine("Wiek: " + osoba.wiek);
                Console.WriteLine("-----------------------------------");
            }

            Osoba[] nowaTablica = new Osoba[5];
            for (int i = 0; i < tablicaOsob.Length; i++)
            {
                nowaTablica[i] = tablicaOsob[i];
            }

            tablicaOsob = nowaTablica;

            tablicaOsob[3] = new Osoba("", "", 0);
            tablicaOsob[4] = new Osoba("", "", 0);

            tablicaOsob[1] = null;
            tablicaOsob[4] = null;

        }

        private bool PorownajOsobaRosnacoWiek(Osoba o1, Osoba o2)
        {
            return (o1.wiek > o2.wiek);
        }

        private bool PorownajOsobaMalejacoWiek(Osoba o1, Osoba o2)
        {
            return (o1.wiek < o2.wiek);
        }

        public void TestListy_int()
        {
            List<int> listaInt = new List<int>();

            listaInt.Add(7);
            listaInt.Add(3);
            listaInt.Add(2);
            listaInt.Add(6);
            listaInt.Add(5);

            //listaInt.Remove(6);
            //listaInt.Insert(2, 9);

            foreach (int elementKolekcji in listaInt)
            {
                Console.Write(elementKolekcji + ", ");
            }

            listaInt.Sort();

            Console.WriteLine();
            Console.WriteLine("Po posortowaniu");
            foreach (int elementKolekcji in listaInt)
            {
                Console.Write(elementKolekcji + ", ");
            }
            Console.WriteLine();

            int min = listaInt.Min();

            Console.WriteLine("Najmniejsza wartosc = " + min);
            Console.WriteLine("Największa wartosc = " + listaInt.Max());
            Console.WriteLine("Średnia wartosc = " + listaInt.Average());

        }

        public void Test_listy()
        {
            List<Osoba> listaOsob = new List<Osoba>();

            listaOsob.Add(new Osoba("Jan", "Kowalski", 20));
            listaOsob.Add(new Osoba("Paweł", "Nowak", 15));
            listaOsob.Add(new Osoba("Karol", "Krawczyk", 18));

            foreach (Osoba osoba in listaOsob)
            {
                Console.WriteLine("Imie: " + osoba.imie);
                Console.WriteLine("Nazwisko: " + osoba.nazwisko);
                Console.WriteLine("Wiek: " + osoba.wiek);
                Console.WriteLine("-----------------------------------");
            }

            listaOsob.Sort((o1, o2) => string.Compare(o2.nazwisko, o1.nazwisko));
            Console.WriteLine("Po posortowaniu");
            foreach (Osoba osoba in listaOsob)
            {
                Console.WriteLine("Imie: " + osoba.imie);
                Console.WriteLine("Nazwisko: " + osoba.nazwisko);
                Console.WriteLine("Wiek: " + osoba.wiek);
                Console.WriteLine("-----------------------------------");
            }

            int wiekMax = listaOsob.Max((Osoba o) => o.wiek);
            Console.WriteLine("Wiek najstarszej osoby " + wiekMax);
        }

        public void Test_Nazwa_Techniczna()
        {
            List<string> nazwyDniTygodniaList = new List<string>();

            nazwyDniTygodniaList.Add("Poniedziałek");
            nazwyDniTygodniaList.Add("Wtorek");
            nazwyDniTygodniaList.Add("Środa");
            nazwyDniTygodniaList.Add("Czwartek");
            nazwyDniTygodniaList.Add("Piątek");
            nazwyDniTygodniaList.Add("Sobota");
            nazwyDniTygodniaList.Add("Niedziela");

            Console.WriteLine("Trzecim dniem tygodnia jest " + nazwyDniTygodniaList[2]);

            nazwyDniTygodniaList.Sort();

            Console.WriteLine("Trzecim dniem tygodnia jest " + nazwyDniTygodniaList[2]);

            //---------------------------------------------------------------------------------

            List<DzienTygodnia> nazwyDniTygodniaObiektList = new List<DzienTygodnia>();

            nazwyDniTygodniaObiektList.Add(new DzienTygodnia(0, "Poniedziałek"));
            nazwyDniTygodniaObiektList.Add(new DzienTygodnia(1, "Wtorek"));
            nazwyDniTygodniaObiektList.Add(new DzienTygodnia(2, "Środa"));
            nazwyDniTygodniaObiektList.Add(new DzienTygodnia(3, "Czwartek"));
            nazwyDniTygodniaObiektList.Add(new DzienTygodnia(4, "Piątek"));
            nazwyDniTygodniaObiektList.Add(new DzienTygodnia(5, "Sobota"));
            nazwyDniTygodniaObiektList.Add(new DzienTygodnia(6, "Niedziela"));

            Console.WriteLine("Trzecim dniem tygodnia jest " + nazwyDniTygodniaObiektList[2].nazwa);

            nazwyDniTygodniaObiektList.Sort((d1, d2) => string.Compare(d1.nazwa, d2.nazwa));

            Console.WriteLine("Trzecim dniem tygodnia jest " + nazwyDniTygodniaObiektList[2].nazwa);

            DzienTygodnia trzeciDzien = nazwyDniTygodniaObiektList.Find(dzien => dzien.numer == 2);

            Console.WriteLine("Trzecim dniem tygodnia jest " + trzeciDzien.nazwa);

            //-----------------------------------------------------------------------------------------

            Dictionary<int, string> nazwyDnitygodniaDictionary = new Dictionary<int, string>();
            nazwyDnitygodniaDictionary.Add(1, "Poniedziałek");
            nazwyDnitygodniaDictionary.Add(2, "Wtorek");
            nazwyDnitygodniaDictionary.Add(3, "Środa");
            nazwyDnitygodniaDictionary.Add(4, "Czwartek");
            nazwyDnitygodniaDictionary.Add(5, "Piątek");
            nazwyDnitygodniaDictionary.Add(6, "Sobota");
            nazwyDnitygodniaDictionary.Add(7, "Niedziela");

            Console.WriteLine("Trzecim dniem tygodnia jest " + nazwyDnitygodniaDictionary[3]);
        }

        public void Linq()
        {
            List<int> listaLiczb = new List<int>();
            Random random = new Random();
            
            listaLiczb.Add(random.Next(1, 101));
            listaLiczb.Add(random.Next(1, 101));
            listaLiczb.Add(random.Next(1, 101));
            listaLiczb.Add(random.Next(1, 101));
            listaLiczb.Add(random.Next(1, 101));

            foreach(int liczba in listaLiczb)
            {
                Console.Write(liczba + ", ");
            }
            Console.WriteLine();

            List<int> listaLiczbWieksza50 = new List<int>();

            foreach (int liczba in listaLiczb)
            {
                if (liczba > 50)
                    listaLiczbWieksza50.Add(liczba);
            }

            Console.WriteLine("Liczby wieksze od 50:");
            foreach(int liczba in listaLiczbWieksza50)
            {
                Console.Write(liczba + ", ");
            }
            Console.WriteLine();

            List<int> listaWynikowa = listaLiczb.Where((int liczba) => liczba > 50).ToList();

            //---------------------------------------------------
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            List<Osoba> listaOsob = new List<Osoba>();
            listaOsob.Add(new Osoba("Jan", "Kowalski", 25));
            listaOsob.Add(new Osoba("Paweł", "Nowak", 60));
            listaOsob.Add(new Osoba("Karolina", "Pawłowska", (byte)random.Next(0, 50)));
            listaOsob.Add(new Osoba("Jan", "Pawłowski", (byte)random.Next(0, 50)));

            foreach (Osoba osoba in listaOsob)
            {
                Console.WriteLine(osoba.imie + " " + osoba.nazwisko + " " +osoba.wiek);
            }
            Console.WriteLine();

            List<Osoba> listaOsobPelnoletnich = new List<Osoba>();
            foreach (Osoba osoba in listaOsob)
            {
                if (osoba.wiek >= 18)
                    listaOsobPelnoletnich.Add(osoba);
            }

            Console.WriteLine("Osoby pełnoletnie:");
            foreach (Osoba osoba in listaOsobPelnoletnich)
            {
                Console.WriteLine(osoba.imie + " " + osoba.nazwisko + " " + osoba.wiek);
            }
            Console.WriteLine();

            List<Osoba> listaOsobJan = new List<Osoba>();
            foreach (Osoba osoba in listaOsob)
            {
                if (osoba.imie == "Jan")
                    listaOsobJan.Add(osoba);
            }

            Console.WriteLine("Osoby o imienu JAN:");
            foreach (Osoba osoba in listaOsobJan)
            {
                Console.WriteLine(osoba.imie + " " + osoba.nazwisko + " " + osoba.wiek);
            }
            Console.WriteLine();

            //-------------------------------------------------------

            List<Osoba> listaOsonPelnoletnichLinq = listaOsob.Where((Osoba osoba) => /*return*/ osoba.wiek > 17 && osoba.imie == "Jan").ToList();
            Console.WriteLine("Osoby pełnoletnie za pomocą Linq:");
            foreach (Osoba osoba in listaOsonPelnoletnichLinq)
            {
                Console.WriteLine(osoba.imie + " " + osoba.nazwisko + " " + osoba.wiek);
            }
            Console.WriteLine();


            List<Osoba> listaWynikowaOsoba;

            listaWynikowaOsoba = listaOsob.Where(os => /*return*/ os.wiek == 20).Take(1).ToList();
            Osoba[] tablicaOsob = listaOsob.Where(os => os.wiek == 18).ToArray();

            Osoba osoba20;
            if (listaWynikowaOsoba.Count > 0)
                osoba20 = listaWynikowaOsoba[0];

            osoba20 = listaOsob.First(os => os.wiek == 20);
            osoba20 = listaOsob.First();
            //osoba20 = listaOsob.Max(osoba20 => (int)osoba20.wiek);

            osoba20 = listaOsob.FirstOrDefault(os => os.wiek == 20);
            if (osoba20 != null)
            {
                osoba20.imie = "Paweł";
            }

            listaWynikowaOsoba = listaOsob.Where(os => os.wiek>17).Where(os => os.imie == "Jan").OrderBy(os => os.imie).ThenBy(os => os.wiek).ToList();

            List<string> listaImionPelnoletnich;



            listaImionPelnoletnich = new List<string>();
            foreach (Osoba os in listaOsob)
            {
                listaImionPelnoletnich.Add(os.imie);
            }

            listaImionPelnoletnich = listaOsob.Where(os=> os.wiek>= 18).Select((Osoba os) => os.imie).Where(s => s == "Jan").ToList();

            var kolekcja1 = listaOsob.Where(os => os.wiek >= 18 && os.imie == "Jan");
            var kolekcja2 = kolekcja1.Select((Osoba os) => os.imie);
            //var kolekcja3 = kolekcja2.Where(s => s == "Jan");
            listaImionPelnoletnich = kolekcja2.ToList();

            /*
             select imie, nazwisko
             from Osoba
             where wiek >= 18 
             */
            List<OsobaImieNazwisko> osobaImieNazwiskos 
                = listaOsob.Where((Osoba os) => os.wiek >= 18)
                .Select((Osoba os) => new OsobaImieNazwisko(os.imie, os.nazwisko))
                //.Where((OsobaImieNazwisko oin) => oin.imie2 == "Jan")
                .ToList();

            osobaImieNazwiskos = 
                (
                    from osoba in listaOsob
                    where osoba.wiek >= 18
                    select new OsobaImieNazwisko(osoba.imie, osoba.nazwisko)
                ).ToList();
        }
    }

    class OsobaImieNazwisko
    {
        public string imie2, nazwisko2;

        public OsobaImieNazwisko(string i, string n)
        {
            imie2 = i;
            nazwisko2 = n;
        }
    }

    class DzienTygodnia
    {
        public int numer;
        public string nazwa;

        public DzienTygodnia(int numer, string nazwa)
        {
            this.numer = numer;
            this.nazwa = nazwa;
        }
    }
}
