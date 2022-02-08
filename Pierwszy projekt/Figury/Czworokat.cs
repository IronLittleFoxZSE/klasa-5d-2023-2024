using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    class Czworokat
    {
        protected string nazwa;
        protected float bokA, bokB, bokC, bokD;
        protected float pole, obwod;
        
        public Czworokat(string nazwa, float bokA, float bokB, float bokC, float bokD)
        {
            this.nazwa = nazwa;
            this.bokA = bokA;
            this.bokB = bokB;
            this.bokC = bokC;
            this.bokD = bokD;
        }

        public void Informacje()
        {
            Console.WriteLine("Obiekt o nazwie " + nazwa);
            Console.WriteLine("Bok a = " + bokA);
            Console.WriteLine("Bok b = " + bokB);
            Console.WriteLine("Bok c = " + bokC);
            Console.WriteLine("Bok d = " + bokD);
            Console.WriteLine("Obwod = " + obwod);
            Console.WriteLine("Pole = " + pole);
        }

        public void ObliczObwod()
        {
            obwod = bokA + bokB + bokC + bokD;
        }
    }
}
