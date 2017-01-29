using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class TrojkatProstokatny: Trojkat // dziedziczenie
    {
        public TrojkatProstokatny() // konstruktor domyślny
        {
        
        }

        public TrojkatProstokatny(double a, double b) // konstruktor parametryczny
        {
            this.a = a;
            this.b = b;
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        
        }

    }
}
