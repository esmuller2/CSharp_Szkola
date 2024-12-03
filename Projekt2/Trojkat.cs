using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2
{
    internal class Trojkat
    {
        private double a, b, c;

        internal void setTrojkat(double a, double b, double c)
        {
            this.a = a; this.b = b; this.c = c;

            if (a < 0)
            {
                this.a = 0;
            }
            if (b < 0)
            {
                this.b = 0;
            }
            if (c < 0)
            {
                this.c = 0;
            }
        }

        internal double obliczPole()
        {
            double pole = (a + b + c) / 2;
            return Math.Sqrt(pole * (pole - a) * (pole - b) * (pole - c));
        }

        internal double obwodT()
        {
            return a + b + c;
        }

        internal bool czyTrojkatIstnieje()
        {
            if((a + b) > c && (a + c) > b && (b + c) > a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal bool czyTrojkatJestProstokanty()
        {
            double max;
            double min1;
            double min2;
            if (a >= b && a >= c)
            {
                max = a;
                min1 = c;
                min2 = b;
            }
            else if (b >= a && b >= c)
            {
                max = b;
                min1 = c;
                min2 = a;
            }
            else
            {
                max = c;
                min1 = a;
                min2 = b;
            }
            if (min1 * min1 + min2 * min2 == max * max)
            {
                return true;
            }
            else
                return false;
        }

        internal bool czyTrojkatJestOstrokatny()
        {
            double max;
            double min1;
            double min2;
            if (a >= b && a >= c)
            {
                max = a;
                min1 = c;
                min2 = b;
            }
            else if (b >= a && b >= c)
            {
                max = b;
                min1 = c;
                min2 = a;
            }
            else
            {
                max = c;
                min1 = a;
                min2 = b;
            }
            if (min1 * min1 + min2 * min2 > max * max)
                return true;
            else
                return false;
        }
        internal bool czyTrojkatJestRozwartokatny()
        {
            double max;
            double min1;
            double min2;
            if (a >= b && a >= c)
            {
                max = a;
                min1 = c;
                min2 = b;
            }
            else if (b >= a && b >= c)
            {
                max = b;
                min1 = c;
                min2 = a;
            }
            else
            {
                max = c;
                min1 = a;
                min2 = b;
            }

            if (min1 * min1 + min2 * min2 < max * max)
                return true;
            else
                return false;
        }
    }
}
