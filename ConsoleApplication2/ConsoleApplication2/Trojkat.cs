using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Trojkat: Ksztalt //dziedziczenie
    {
        public Trojkat() // konstruktor domyślny
        {
        
        }

        public Trojkat(double a, double b, double c) // konstruktor parametryczny
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double ObliczObwod() // przesłonięcie metody ObliczObwod
        {
            return a + b + c;
        }

        public override double ObliczPole() // przesłonięcie metody ObliczPole
        {
            double p = ObliczObwod() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
