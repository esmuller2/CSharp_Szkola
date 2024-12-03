using System.Text.RegularExpressions;

namespace regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string text = "bacvvvabccacbbbbabc";
            //string r = "ab*c";
            //Regex regex = new Regex(r);
            //Console.WriteLine(regex.IsMatch(text));
            //foreach (Match match in regex.Matches(text))
            //{
            //    Console.WriteLine(match);
            //}
            //Console.WriteLine(regex.Match(text));

            //napisz program sprawdzający poprawność danych wprowadzonych przez użytkownika i czy jest poprawne
            //kod pocztowy
            //telefon + 48 opcjonalnie
            //email
            //adres strony internetowej https//:www.wp.pl | wp.pl |
            // www.wp.pl | https//:wp.pl | http//:www.wp.pl
            //pesel
            //program działa w pętli
            while (true)
            {
                try
                {
                    String wybor;
                    Console.WriteLine();
                    Console.WriteLine($"Wybierz opcję:\n" +
                        $"1 - Kod pocztowy \n" +
                        $"2 - Telefon\n" +
                        $"3 - Email\n" +
                        $"4 - adres strony\n" +
                        $"5 - pesel\n" +
                        $"6- Wyjście");
                    Console.WriteLine();
                    Console.Write("Podaj Opcję: ");
                    wybor = Console.ReadLine();
                    switch (wybor)
                    {
                        case "1":
                            string r = "^[0-9]{2}-[0-9]{3}$";
                            Regex regex = new Regex(r);

                            Console.Write("Podaj kod pocztowy: ");
                            String kod = Console.ReadLine();
                            if (regex.IsMatch(kod))
                            {
                                Console.WriteLine("Kod pocztowy: " + kod);
                            }
                            else
                            {
                                Console.WriteLine("Podano błędny kod pocztowy");
                            }
                            break;
                        case "2":
                            string r2 = "^(\\+\\d\\d){0,1}\\s*(\\d{3})\\s*(\\d{3})\\s*(\\d{3})$";   
                            Regex regex2 = new Regex(r2);

                            Console.Write("Podaj numer telefonu: ");
                            String kod2 = Console.ReadLine();
                            if (regex2.IsMatch(kod2))
                            {
                                Console.WriteLine("Numer telefonu: " + kod2);
                            }
                            else
                            {
                                Console.WriteLine("Podano błędny numer telefonu");
                            }
                            break;
                        case "3":
                            string r3 = "^[!-z]{2,}@{1}[!-z]{1,}\\.[A-z]{2,4}$";
                            Regex regex3 = new Regex(r3);

                            Console.Write("Podaj adres email: ");
                            String kod3 = Console.ReadLine();
                            if (regex3.IsMatch(kod3))
                            {
                                Console.WriteLine("adres email: " + kod3);
                            }
                            else
                            {
                                Console.WriteLine("Podano błędny adres email");
                            }
                            break;
                        case "4":
                            string r4 = "^((http)s*:\\/\\/)*[0-z]+\\.[A-z]{1,4}[!-z]*$";
                            Regex regex4 = new Regex(r4);

                            Console.Write("Podaj adres strony inernetowej: ");
                            String kod4 = Console.ReadLine();
                            if (regex4.IsMatch(kod4))
                            {
                                Console.WriteLine("adres strony internetowej: " + kod4);
                            }
                            else
                            {
                                Console.WriteLine("Podano błędny adres strony internetowej");
                            }
                            break;
                        case "5":
                            Console.Write("Podaj PESEL: ");
                            String kod5 = Console.ReadLine();
                            char[] list = kod5.ToCharArray();
                            int[] ints = Array.ConvertAll(list, c => (int)Char.GetNumericValue(c));
                            int num = (1 * ints[0]) + (3 * ints[1]) + (7 * ints[2]) + (9 * ints[3]) + (1 * ints[4]) + (3 * ints[5]) + (7 * ints[6]) + (9 * ints[7]) + (1 * ints[8]) + (3* ints[9]);
                            int[] final = num.ToString().Select(o => Convert.ToInt32(o)-48).ToArray();
                            if (10 - final[0] == ints[10])
                            {
                                Console.WriteLine("PESEL: "+kod5);
                            }
                            else
                            {
                                Console.WriteLine("Błędny PESEL");
                            }
                            break;
                        case "6":
                            System.Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Podana opcja nie istnieje");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

        }
    }
}