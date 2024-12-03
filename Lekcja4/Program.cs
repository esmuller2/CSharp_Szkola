namespace Lekcja4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.ForegroundColor = ConsoleColor.DarkRed;
            //Console.BackgroundColor = ConsoleColor.DarkRed;

            //Console.WriteLine("Arbuz Arbuz Privet");

            string tt = "Arbuz Arbuz Privet Arbuz Arbuz Privet";
            string tt1 = "Privet Privet Drug";

            foreach (char znak in tt)
            {
                //Console.Write(znak);
                System.Threading.Thread.Sleep(1);
            }

            //Console.WriteLine(" ");
            
            for (int i = 0; i < tt1.Length; i++)
            {
                //Console.Write(tt1[i]);
                Thread.Sleep(1);
            }

            //Console.WriteLine(" ");

            string t = "23";
            byte b1 = 32;
            bool czyKonwersuje = Byte.TryParse(t,out b1);

            if(czyKonwersuje)
            {
                b1 = Convert.ToByte(t);
                //Console.WriteLine(b1);
            } else
            {
                //Console.WriteLine("Nie mozna kowerwtowac");
            }

            //Console.WriteLine("");
            Console.WriteLine("- - - Losowanie - - -");

            Random los = new Random();
            int liczba = los.Next(1,10); // Przedział od 1 do 9.
            Console.WriteLine(liczba);

            // losowanie koloru

            int lKoloruTla;
            ConsoleColor kolortla;

            while(true)
            {

                lKoloruTla = los.Next(16);
                kolortla = (ConsoleColor)lKoloruTla;
                Console.BackgroundColor = kolortla;
                Console.Clear();
                Thread.Sleep(500);
   
            }

            Console.ReadKey();
        }
    }
}