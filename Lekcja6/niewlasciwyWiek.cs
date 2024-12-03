using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja6
{
    internal class niewlasciwyWiek:Exception
    {
        public niewlasciwyWiek(string komunikat) {
            Console.WriteLine(komunikat);
        }
    }
}
