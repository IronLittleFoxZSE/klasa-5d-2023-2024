using System;
using System.Collections.Generic;
using System.Linq;

namespace PeselForms.Model
{
    class Pesel
    {
        private string numerPesel;



        public string Plec
        {
            get
            {
                char cyfraPlec = numerPesel[9];
                int liczbaPlec = int.Parse(cyfraPlec.ToString());
                if (liczbaPlec % 2 == 0)
                    return "Kobieta";
                else
                    return "Mężczyzna";
            }
        }

        public int Dzien
        {
            get
            {
                return int.Parse(numerPesel[4].ToString() + numerPesel[5].ToString());
            }
        }

        public int Miesiac
        {
            get
            {
                return ZwrocMiesiac();
            }
        }

        public int Rok
        {
            get
            {
                return ZwrocRok();
            }
        }

        public Pesel(string numer)
        {
            numerPesel = numer;
            WalidacjaNumeruPesel();
        }

        private void WalidacjaNumeruPesel()
        {
            WalidacjaIloscZnakow();
            WalidacjaPoprawnosciZnakow();
            WalidacjaDnia();
            WalidacjaMiesiaca();
            WalidacjaCyfryKontrolnej();
        }

        private void WalidacjaPoprawnosciZnakow()
        {
            for (int i = 0; i < numerPesel.Length; i++)
            {
                if (numerPesel[i] < '0' || numerPesel[i] > '9')
                    throw new Exception("Podany ciąg musi składać się tylko z cyfr");
            }
        }

        private void WalidacjaCyfryKontrolnej()
        {
            int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int sumaWag = 0;
            for (int i = 0; i < numerPesel.Length-1; i++)
            {
                sumaWag += wagi[i] * int.Parse(numerPesel[i].ToString());
            }

            int obliczonaCyfraKontrolna = 0;
            if (sumaWag % 10 != 0)
                obliczonaCyfraKontrolna = 10 - sumaWag % 10;

            if (obliczonaCyfraKontrolna != int.Parse(numerPesel[10].ToString()))
                throw new Exception("Błędna cyfra kontrolna");
        }

        private void WalidacjaMiesiaca()
        {
            int miesiac = int.Parse(numerPesel[2].ToString() + numerPesel[3].ToString());
            int[][] zakresyMiesiacy = { new[] { 1, 12 }, new[] { 21, 32 }, new[] { 41, 52 }, new[] { 61, 72 }, new[] { 81, 92 } };

            foreach (int[] tabelaZakresow in zakresyMiesiacy)
            {
                if (miesiac >= tabelaZakresow[0] && miesiac <= tabelaZakresow[1])
                    return;
            }

            throw new Exception("Błedny miesiac");
        }

        private void WalidacjaDnia()
        {
            int dzien = int.Parse(numerPesel[4].ToString() + numerPesel[5].ToString());
            int miesiac = ZwrocMiesiac();
            int rok = ZwrocRok();
            if (dzien > 31)
                throw new Exception("Błedny dzień");

            switch (miesiac)
            {

                case 2:
                    if (dzien > 29)
                        throw new Exception("Błedny dzień");
                    if (!(rok % 4 == 0 && rok % 100 != 0 || rok % 400 == 0) && dzien > 28)
                        throw new Exception("Błedny dzień");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (dzien == 31)
                        throw new Exception("Błedny dzień");
                    break;
            }
        }

        private void WalidacjaIloscZnakow()
        {
            if (numerPesel.Length != 11)
                throw new Exception("Błędna ilość znaków w numerze.");
        }

        private int ZwrocRok()
        {
            int[][] zakresyMiesiacy = { new[] { 1, 12 }, new[] { 21, 32 }, new[] { 41, 52 }, new[] { 61, 72 }, new[] { 81, 92 } };
            int[] stulecia = { 1900, 2000, 2100, 2200, 1800 };

            int miesiac = int.Parse(numerPesel[2].ToString() + numerPesel[3].ToString());
            int rok = int.Parse(numerPesel[0].ToString() + numerPesel[1].ToString());

            for(int i = 0; i < zakresyMiesiacy.Length; i++)
            {
                if (miesiac >= zakresyMiesiacy[i][0] && miesiac <= zakresyMiesiacy[i][1])
                {
                    rok += stulecia[i];
                    break;
                }
            }

            return rok;
        }

        private int ZwrocMiesiac()
        {
            int[][] zakresyMiesiacy = { new[] { 1, 12, 0 }, new[] { 21, 32, 20 }, new[] { 41, 52, 40 }, new[] { 61, 72, 60 }, new[] { 81, 92, 80 } };
            int miesiac = int.Parse(numerPesel[2].ToString() + numerPesel[3].ToString());

            foreach (int[] tabelaZakresow in zakresyMiesiacy)
            {
                if (miesiac >= tabelaZakresow[0] && miesiac <= tabelaZakresow[1])
                {
                    miesiac -= tabelaZakresow[2];
                }
            }

            return miesiac;
        }
    }
}
