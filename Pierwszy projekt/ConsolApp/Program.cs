//unsigned int a, b;
using System;

uint a, b;

Console.WriteLine("Podaj a:");
a = uint.Parse(Console.ReadLine());

Console.WriteLine("Podaj b:");
b = uint.Parse(Console.ReadLine());

a = NWD(a, b);
Console.WriteLine(a);

/*
**********************************************
nazwa funkcji: NWD
opis funkcji: oblicza NWD dwóch liczb
parametry: a - pierwsza liczba
           b - druga liczba
zwracany typ i opis: uint - obliczony NWD dwóch liczb
autor: PESEL
***********************************************
*/
uint NWD(uint a, uint b)
{
    while(a != b)
    {
        if (a > b)
            a = a - b;
        else
            b = b - a;
    }
    return a;
}