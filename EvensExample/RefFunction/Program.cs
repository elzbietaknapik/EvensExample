using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            bool parse;
            int nr = 0;
            do {
                Console.WriteLine("Podaj liczbę naturalną: ");
                 parse = Int32.TryParse(Console.ReadLine(), out  nr);
            }
            while (!parse);


            if (Evens(nr))
            {
                Console.WriteLine("Liczba " + nr + " jest parzysta");
            }
            else
                Console.WriteLine("Liczba " + nr + " jest nieparzysta");

            Console.ReadKey();

          
        }

        static bool Evens (int number)
        {
            int modulo = number % 2;
            if (modulo != 0) return false;
            else return true;
        }
    }
}
