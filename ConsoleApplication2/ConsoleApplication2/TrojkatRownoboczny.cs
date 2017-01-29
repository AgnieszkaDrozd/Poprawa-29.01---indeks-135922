using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class TrojkatRownoboczny: Trojkat // dziedziczenie
    {

        public TrojkatRownoboczny() // konstruktor domyślny
        {

        }

        public TrojkatRownoboczny(double a) //konstruktor parametryczny
        {
            this.a = a;
            b = a;
            c = a;
        }
        

    }
}
