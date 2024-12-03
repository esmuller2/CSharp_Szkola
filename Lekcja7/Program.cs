namespace Lekcja7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- - - Lekcja 7 - - -");

            int a;

            do {
                try {

                    Console.Write("Podaj liczbę z przedziału od 0 do 9: ");
                    a = Convert.ToInt32(Console.ReadLine());

                    if((a >= 0) && (a <= 9)) {
                        Console.WriteLine("Podałeś prawidłową liczbę!");
                        break;
                    } else { 
                        Console.WriteLine("Podałeś złą liczbę!");
                    }

                }
                catch(Blad_zakresu e) {
                    Console.WriteLine(e);
                }
                catch(FormatException e) { 
                    Console.WriteLine("Błą typu danych!");
                }
                catch (Exception e) {

                    Console.WriteLine("Błąd " + e.Message);

                }
            } while (true);

            Console.ReadKey();
        }
    }
}
