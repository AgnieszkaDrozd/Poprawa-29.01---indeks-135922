using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ksztalt> figury = new List<Ksztalt>(); // lista trójkątów
            figury.Add(new Trojkat(5, 8, 9));
            figury.Add(new Trojkat(7, 3, 9));
            figury.Add(new Trojkat(5, 2, 38));
            figury.Add(new Trojkat(5, 34, 3));
            figury.Add(new TrojkatProstokatny(7, 3));
            figury.Add(new TrojkatProstokatny(4, 8));
            figury.Add(new TrojkatProstokatny(8, 23.2));
            figury.Add(new TrojkatRownoboczny(2.15));
            figury.Add(new TrojkatRownoboczny(8));
            figury.Add(new TrojkatRownoboczny(4));

            Console.WriteLine();

            foreach (var f in figury) // elementy o polu większym niż 10
                if (f.ObliczPole() > 10)
                    Console.WriteLine(f);

            Console.WriteLine();

            Console.WriteLine(); // elementy o obwodzie mniejszym lub równym 20
            foreach (var f in figury)
                if (f.ObliczObwod() <= 20)
                    Console.WriteLine(f); 

            Console.WriteLine();

            figury.Add(new Czworokat(3, 5.5, 3, 8.3)); // lista czworokątów
            figury.Add(new Czworokat(7, 1, 4.5, 7));
            figury.Add(new Czworokat(2.34, 4.22, 11.67, 3.2));
            figury.Add(new Czworokat(5.6, 2.2, 6.3, 4.4));
            figury.Add(new Prostokat(4.5, 23.5));
            figury.Add(new Prostokat(7.21, 2.85));
            figury.Add(new Prostokat(9, 24.5));
            figury.Add(new Kwadrat(9.32));
            figury.Add(new Kwadrat(8.67));
            figury.Add(new Kwadrat(2.91));

            foreach(var f in figury) // elementy których pole jest między 12 a 24
            {
                double pole = f.ObliczPole();
                if (pole >= 12 && pole <= 24)
                    Console.WriteLine(f);
            }

            Console.ReadKey();
        }
    }
}
