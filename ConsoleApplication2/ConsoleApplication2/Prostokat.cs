using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Prostokat: Czworokat // dziedziczenie
    {
        public Prostokat() // konstruktor domyślny
        {

        }
        public Prostokat(double a, double b) // konstruktor parametryczny
        {
            this.a = a;
            this.c = b;
            this.b = a;
            this.d = b;
        }
    }
}
