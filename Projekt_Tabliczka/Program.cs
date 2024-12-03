namespace Tabliczka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- - - Tabliczka Mnożenia - - -");

            while (true)
            {
                try
                {
                    int a;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Wykonaj Mnożenie - 1");
                    Console.WriteLine("Wyjdź z programu - 2");
                    Console.Write("Wybierz Opcję: ");

                    a = Convert.ToInt32(Console.ReadLine());

                    try
                    {

                        switch (a)
                        {
                            case 1:
                            
                            int a1, a2;

                                    Console.Write("Podaj 1 liczbę: ");
                                    a1 = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Podaj 2 liczbę: ");
                                    a2 = Convert.ToInt32(Console.ReadLine());

                                if (a1 > 10 || a1 < 0 || a2 > 10 || a2 < 0)
                                    {
                                        throw new Liczba();
                                    }
                                    else
                                    {
                                        int w = a1 * a2;
                                        Console.WriteLine("Wynik mnożenia to: " + w);
                                    }
                                    break;
                                
                            case 2:
                                Environment.Exit(0);
                                break;
                        }
                    } 
                    catch (Liczba e)
                    {

                    }
                    catch (Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Błąd " + e.Message);
                    }
                } catch (Exception c)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Podaj liczbę 1 lub 2!");
                }
            }
            
        }

    }
}
