namespace Lekcja_3_Metody_i_Pola_Statyczne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metody Statyczme - Static");

            int x = 10;
            //Console.WriteLine(x);

            double y = x;
            //Console.WriteLine(y);

            double z = 210.13;
            //Console.WriteLine(z);

            // Konwertowanie double na int w sposób jawny, reszta jest niejawna bez (X)
            int a = (int)z; 
            //Console.WriteLine(a);

            // (int) - konwersja na int z -
            // (uint) - konwersja na int bez -

            char znak = '9';
            int kod = znak;

            //Console.WriteLine(kod);

            int kod1 = 255;
            char znak1 = (char)kod1;

            //.WriteLine(znak1);

            string t1 = "23";
            int l1 = System.Convert.ToInt32(t1);

            //Console.WriteLine(l1);

            int l2 = 20;
            string t2 = Convert.ToString(l2);

            //Console.WriteLine(t2);


            byte b1 = 2;
            int b2 = (int)b1;

            //Console.WriteLine(b2);

            int b3 = 123;
            byte b4 = (byte)b3;

            //Console.WriteLine(b4);

            double x1, x2;
            double w;

            Console.WriteLine("Podaj 1 liczbe: ");
            x1 = System.Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj 2 liczbe: ");
            x2 = System.Convert.ToDouble(Console.ReadLine());

            w = x1 + x2;
            Console.WriteLine($"{x1}+{x2}={w}");

            w = x1 - x2;
            Console.WriteLine($"{x1}-{x2}={w}");

            w = x1 * x2;
            Console.WriteLine($"{x1}*{x2}={w}");

            w = x1 / x2;
            Console.WriteLine($"{x1}/{x2}={w}");


            System.Console.ReadKey();
        }
    }
}