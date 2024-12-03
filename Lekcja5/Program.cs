namespace Lekcja5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tablice");

            int[] temperatury = new int[365];

            for (int i = 0; i < temperatury.Length; i++)
            {
                Random rand = new Random();
                temperatury[i] = rand.Next(10,41);
                Console.Write(temperatury[i] + " ");

                if (i%20 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            int c = 0;
            foreach (var item in temperatury)
            {
                Console.Write(item + " ");

                c++;
                if (c % 20 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            string[] dni_tygodnia = new string[7] { "Poniedziałek", "Wtorek", "Środa", "Czwartek", "Piątek", "Sobota", "Dawid Niedziela" };

            Console.ReadKey();
        }
    }
}
