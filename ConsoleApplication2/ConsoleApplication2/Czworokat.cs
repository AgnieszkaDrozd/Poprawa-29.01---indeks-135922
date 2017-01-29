using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Czworokat: Ksztalt // dziedziczenie
    {

        public Czworokat() // konstruktor domyślny
        {

        }
        public Czworokat(double a, double b, double c, double d) // konstruktor parametryczny
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public override double ObliczObwod() // przesłonięcie metody ObliczObwod
        {
            return a + b + c + d;
        }

        public override double ObliczPole() // przesłonięcie metody ObliczPole
        {
            double p = ObliczObwod() / 2;
            return Math.Sqrt((p - a) * (p - b) * (p - c) * (p - d));
        }       
    }
}
