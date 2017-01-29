using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Kwadrat : Prostokat // dziedziczenie
    {

        public Kwadrat(double a) // kontruktor parametryczny
        {
            this.a = a;
            this.b = a;
            this.c = a;
            this.d = a;
        }
    }
}
