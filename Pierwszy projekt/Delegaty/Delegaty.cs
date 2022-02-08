using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty
{
    class Delegaty
    {
        delegate int OperacjaDoWykonaniaDelegate(int a, int b);
        delegate void WyswietlWynikOperacjiDelegate(int w, char o);

        public void TestDelegat()
        {
            Console.WriteLine("Podaj pierwszą liczbę:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj operację do wykonania");
            char operacja = Console.ReadLine()[0];
            int wynik = 0;

            //wersja pierwsza
            switch(operacja)
            {
                case '+':
                    wynik = Suma(x, y);
                    break;
                case '*':
                    wynik = Iloczyn(x, y);
                    break;
                default:
                    wynik = 0;
                    break;
            }
            WyswietlWynikOperacji(wynik, operacja);

            //wersja druga delegaty
            OperacjaDoWykonaniaDelegate operacjaDoWykonaniaDelegate;
            switch (operacja)
            {
                case '+':
                    //wynik = Suma(x, y);
                    operacjaDoWykonaniaDelegate = Suma;
                    break;
                case '*':
                    //wynik = Iloczyn(x, y);
                    operacjaDoWykonaniaDelegate = Iloczyn;
                    break;
                default:
                    //wynik = 0;
                    operacjaDoWykonaniaDelegate = null;
                    break;
            }
            if (operacjaDoWykonaniaDelegate == null)
                wynik = 0;
            else
                wynik = operacjaDoWykonaniaDelegate(x, y);
            WyswietlWynikOperacjiDelegate wyswietlWynikOperacjiDelegate = WyswietlWynikOperacji;
            wyswietlWynikOperacjiDelegate(wynik, operacja);

            //wersja trzecia akcje i funkcje
            Func<int, int, int> operacjaDoWykoaniaFunc;
            switch (operacja)
            {
                case '+':
                    //wynik = Suma(x, y);
                    operacjaDoWykoaniaFunc = Suma;
                    break;
                case '*':
                    //wynik = Iloczyn(x, y);
                    operacjaDoWykoaniaFunc = Iloczyn;
                    break;
                default:
                    //wynik = 0;
                    operacjaDoWykoaniaFunc = null;
                    break;
            }
            if (operacjaDoWykoaniaFunc == null)
                wynik = 0;
            else
                wynik = operacjaDoWykoaniaFunc(x, y);
            Action<int, char> wyswietlWynikOperacjiFunc = WyswietlWynikOperacji;
            wyswietlWynikOperacjiFunc(wynik, operacja);

            //wersja czwarta funkcje anonimowe

            Func<int, int, int> operacjaDoWykonaniaAnonimowa;
            switch (operacja)
            {
                case '+':
                    //wynik = Suma(x, y);
                    operacjaDoWykonaniaAnonimowa = delegate (int xx, int yy)
                                                            {
                                                                return xx + yy;
                                                            };
                    break;
                case '*':
                    //wynik = Iloczyn(x, y);
                    operacjaDoWykonaniaAnonimowa = delegate (int xx, int yy)
                                                            {
                                                                return xx * yy;
                                                            };
                    break;
                default:
                    //wynik = 0;
                    operacjaDoWykonaniaAnonimowa = null;
                    break;
            }
            if (operacjaDoWykonaniaAnonimowa == null)
                wynik = 0;
            else
                wynik = operacjaDoWykonaniaAnonimowa(x, y);
            Action<int, char> wyswietlWynikOperacjiAnonimowa = delegate (int w, char o)
                                                                         {
                                                                             Console.WriteLine($"Wynik operacji {o} to {w}");
                                                                         };
            wyswietlWynikOperacjiAnonimowa(wynik, operacja);

            //wersja Piąta wyrażenia lambda
            Func<int, int, int> operacjaDoWykonaniaLambda;
            switch (operacja)
            {
                case '+':
                    //wynik = Suma(x, y);
                    operacjaDoWykonaniaLambda = (int xx, int yy) =>
                                                {
                                                    return xx + yy;
                                                };
                    break;
                case '*':
                    //wynik = Iloczyn(x, y);
                    operacjaDoWykonaniaLambda = (xx, yy) => xx * yy;
                    break;
                default:
                    //wynik = 0;
                    operacjaDoWykonaniaLambda = null;
                    break;
            }
            if (operacjaDoWykonaniaLambda == null)
                wynik = 0;
            else
                wynik = operacjaDoWykonaniaLambda(x, y);
            Action<int, char> wyswietlWynikOperacjiLambda = (w, o) => Console.WriteLine($"Wynik operacji {o} to {w}");
            wyswietlWynikOperacjiLambda(wynik, operacja);
        }
        private void WyswietlWynikOperacji(int wynik, char operacja)
        {
            Console.WriteLine($"Wynik operacji {operacja} to {wynik}");
        }

        private int Iloczyn(int x, int y)
        {
            return x * y;
        }

        private int Suma(int x, int y)
        {
            return x + y;
        }
    }
}
