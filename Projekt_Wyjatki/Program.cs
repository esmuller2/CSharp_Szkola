namespace Wyjatki2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b = 1;


            while (true) 
            {
                try
                {
                    Console.Write("Podaj liczbę całkowitą A: ");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"a = {a}");
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Niewłaściwy format danych: " + ex.Message);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Przekroczono zakres: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Błąd: " + ex.Message);
                }
            }

            bool blad;
            do
            {
                blad = false;

                try
                {
                    Console.Write("Podaj liczbę całkowitą B: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"b = {b}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Niewłaściwy format danych: " + ex.Message);
                    blad = true;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Przekroczono zakres: " + ex.Message);
                    blad = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Błąd: " + ex.Message);
                    blad = true;
                }
            } while (blad);


            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"a - b = {a - b}");
            Console.WriteLine($"a * b = {a * b}");
            if (b != 0)
            {
                Console.WriteLine($"a / b = {(double)a / b}");
            }
            else
            {
                Console.WriteLine("Nie można dzielić przez 0");
            }
        }
    }
}
