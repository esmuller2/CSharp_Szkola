namespace Lekcja8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- - - Lekcja 8 - - -");

            double x; int y;

            Console.Write("Podaj liczbę: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(x);

            Console.Write("Podaj liczbę całkowitą: ");
            
            if(int.TryParse(Console.ReadLine(), out y)) { 
                Console.WriteLine(y + y);
            } else {
                Console.WriteLine("Błędne Dane");
            }
          

            Console.ReadKey();
        }
    }
}