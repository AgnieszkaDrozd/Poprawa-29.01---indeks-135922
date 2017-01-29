using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    abstract class Ksztalt
    {
        protected double a, b, c, d; // deklaracje zmiennych

        public Ksztalt() // konstruktor domyślny
        {

        }

        abstract public double ObliczPole(); // metody abstrakcyjne
        abstract public double ObliczObwod();

        public override string ToString() // przesłonięcie metody
        {
            return "Obwód: " + ObliczObwod().ToString("N2") + ", Pole: " + ObliczPole().ToString("N2") + '.';
        }
        
     

  
    }
}
