using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    class Program
    {
        static void Main(string[] args)
        {
            Prostokat p = new Prostokat("Prostokat", 5, 6);
            p.ObliczObwod();
            p.ObliczPole();
            p.Informacje();

            Kwadrat k = new Kwadrat("Kwadrat", 5);
            k.ObliczObwod();
            k.ObliczPole();
            k.Informacje();

            Console.ReadLine();
        }
    }
}
