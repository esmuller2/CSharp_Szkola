using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja_Tablice
{
    internal class Tablica
    {

        public static void Wyswietl_Tablice(int[] tab)
        {

            Console.WriteLine(tab);

        }

        public static void Wypelnij_Tablice(int[] tab, int ile)
        {

            Random random = new();

            for(int i = 0; i < tab.Length; i++) 
            {
                tab. = random.Next(100);
            }

        }

    }
}
