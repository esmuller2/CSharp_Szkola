namespace Lekcja6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- - -Obsługa wyjątków- - -");

            double a, b, c;

            try {

                Console.Write("Podaj liczbę A: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Podaj liczbę B: ");
                b = Convert.ToDouble(Console.ReadLine());
                if(b == 0)
                {
                    throw new DivideByZeroException();
                }

                c = a / b;
                Console.WriteLine();
                Console.WriteLine($"{a} / {b} = {c}");
            
            }
            catch (DivideByZeroException e1)
            {
                Console.WriteLine("Błąd dzielenia przez 0");
            }
            catch (Exception e2) {
                Console.WriteLine("Error: " + e2.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Program działa dalej");
            Console.WriteLine();

            int wiek;

            try {
                Console.Write("Podaj swój wiek:");
                wiek = Convert.ToInt32(Console.ReadLine());

                if((wiek < 0) || (wiek > 150)) {
                    throw new niewlasciwyWiek("Wiek musi być w przedziale <0;150>");
                }

            } catch(Exception e) {
                Console.WriteLine("Error: " + e.Message);
            }

            Console.ReadKey();
        }
    }
}
