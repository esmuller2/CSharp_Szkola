// using System

namespace Lekcja1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("A");

            while(Console.ReadKey().Key != ConsoleKey.Escape)
            {
                System.Console.WriteLine("Wcisnieto klawisz escape");
            };

            while(true)
            {
                System.Environment.Exit(0);
            };

            // System.Console.WriteLine("Koniec");

        }
    }
}
