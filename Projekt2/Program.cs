namespace Projekt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            Napisz Projekt "Trójkąty" z osobną klasą trójkąt:
                   - 3 Boki
            Metody:
                   - Pole
                   - Obwód
                   - Czy trójkąt istnieje 
                   - Czy jest prostokątny
                   - Czy jest rozwartokątny
                   - Czy jest ostrokątny 
            Program działa w pętli, obsługa błędów, pola prywatne,
            */
            while (true)
            {
                try
                {
                    int wybor;
                    System.Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("- - - MENU - - -");
                    Console.WriteLine("1. Włącz Program");
                    Console.WriteLine("2. Wyjście z Programu");
                    Console.Write("Podaj Liczbę: ");
                    wybor = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (wybor)
                    {
                        case 1:

                            System.Console.ForegroundColor= ConsoleColor.White;
                            Console.Write("Podaj 1 bok trójkąta: ");
                            double a = double.Parse(Console.ReadLine());
                            Console.Write("Podaj 2 bok trójkąta: ");
                            double b = double.Parse(Console.ReadLine());
                            Console.Write("Podaj 3 bok trójkąta: ");
                            double c = double.Parse(Console.ReadLine());

                            Trojkat trojkat1 = new Trojkat();
                            trojkat1.setTrojkat(a, b, c);

                            if(a == 0 || b == 0 || c == 0)
                            {
                                System.Console.ForegroundColor= ConsoleColor.Red;
                                throw new Exception("Długości boków nie mogą wynosić 0!");
                            }

                            if(trojkat1.czyTrojkatIstnieje() == false)
                            {
                                System.Console.ForegroundColor = ConsoleColor.Red;
                                throw new Exception("Trójkąt nie istnieje!");
                            }

                            Console.WriteLine($"Twój trójkąt ma boki: {a} , {b} , {c} ");
                            Console.WriteLine("Pole trójkąta = " + trojkat1.obliczPole());
                            Console.WriteLine("Obwód trójkąta = " + trojkat1.obwodT());
                            if(a != 0 && b != 0 && c != 0)
                            {
                                if(trojkat1.czyTrojkatJestOstrokatny() == true)
                                {
                                    Console.WriteLine("Trójkąt jest ostrokątny!");
                                } else if(trojkat1.czyTrojkatJestProstokanty() == true)
                                {
                                    Console.WriteLine("Trójkąt jest prostokątny!");
                                } else
                                {
                                    Console.WriteLine("Trójkąt jest rozwartokątny!");
                                }
                            }



                            break;

                        case 2:
                            System.Environment.Exit(0);
                            break;

                        default:
                            System.Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Podaj Poprawną Liczbę!");
                            Console.WriteLine();
                            break;
                    }
                } catch (Exception e)
                {
                    Console.WriteLine("Błąd: " + e.Message);
                    Console.WriteLine();
                }
            }

        }
    }
}
