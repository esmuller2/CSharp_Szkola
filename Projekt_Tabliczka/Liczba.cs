using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabliczka
{
    internal class Liczba : Exception
    {
        public Liczba() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Podaj liczbę z przedziału od 0 do 10!");
        }
    }
}
