namespace Trojkaty
{
    /*nPISZ PORRJEKT trojkaty
     * z osobna klasa trojkat:
     * -trzy boki(double)
     * metody:
     * pole (wzor herona)
     * obwod
     * czy_trojkat_istnieje (boolean)
     * czy_jest_prostokatny
     * czy_jest_rozwartokatny
     * czy_jest_ostrokatny
     * obluga bledow program dziala w petli az uzytkownik zdecyduje o wyjsciu
     * dlugosci nie moga byc ujemne i pola prywatne
     * boki ustawiamy za pomoca settera w ktorym kontrolujemy czy boki nie sa ujemne
     * jezeli uzytkownik poda wartosc ujemna to to bok ma 0
     * metoda ktora wyswietla informacje o trojkacie
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
               
                Console.WriteLine("Jeżeli chcesz kontynuować kliknij( c ), żeby zakończyć kliknij ( e )");
                char wybor=Convert.ToChar(Console.ReadLine());
                Console.Clear();
                switch (wybor)
                {
                    case 'c':
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Podaj boki trojkata: ");
                                double a = Convert.ToDouble(Console.ReadLine());
                                double b = Convert.ToDouble(Console.ReadLine());
                                double c = Convert.ToDouble(Console.ReadLine());
                                Trojkat t1 = new Trojkat();
                                t1.setTrojkat(a, b, c);
                                Console.Clear() ;
                                if (a <= 0 || b <= 0 || c < 0)
                                    throw new Exception("Dlugosci bokow nie moga być mniejsze bądz równe 0!!!");
                                if (t1.czyTrojkatIstnieje() == false)
                                    throw new Exception("Taki trojkat nie istnieje!!!");
                                Console.WriteLine($"Twój trójkąt({a}, {b}, {c}): ");
                                Console.WriteLine("Pole: " + t1.Pole());
                                Console.WriteLine("Obwód: " + t1.Ob());
                                if (a != 0 && b != 0 && c != 0)
                                {
                                    if (t1.czyTrojkatJestProstokatny() == true)
                                        Console.WriteLine("Ten trójkąt jest prostokątny ");
                                    else if (t1.czyTrojkatJestOstrokatny() == true)
                                        Console.WriteLine("Ten trójkąt jest ostrokątny ");
                                    else
                                        Console.WriteLine("Ten trójkąt jest rozwartokątny ");
                                }
                                break;
                            }
                            catch (Exception ex) 
                            {
                                Console.WriteLine("Wykryto błąd "+ex.Message);
                            }
                        }
                        break;
                    case 'e':
                        Console.WriteLine("Koniec!!!");
                        System.Environment.Exit(0);
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Wcisnąłeś zły klawisz spróbuj ponownie!!!");
                        break;
                }
            }


        }
    }
}
    