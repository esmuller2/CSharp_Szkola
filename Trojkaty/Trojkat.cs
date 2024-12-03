using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Trojkaty
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
        internal double Pole()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
        internal double Ob()
        {
            return a + b + c;
        }
        internal bool czyTrojkatIstnieje()
        {
            if((a+b)>c && (a+c)>b && (b + c) > a)
            {
                return true;
            }
            else
                return false;
        }
        internal bool czyTrojkatJestProstokatny()
        {
            double max;
            double min1 ;
            double min2 ;
            if (a>=b && a >= c)
            {
                max = a;
                min1 = c;
                min2 = b;
            }
            else if(b>=a && b >= c)
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
            double alpha = Math.Acos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c));
            double gamma = Math.Acos((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b));
            double beta = Math.Acos((Math.Pow(c, 2) + Math.Pow(a, 2) - Math.Pow(b, 2)) / (2 * a * c));
            alpha = alpha * 180 / Math.PI;
            gamma = gamma * 180 / Math.PI;
            beta = beta * 180 / Math.PI;

            if (alpha<90 || gamma <90 || beta<90)
                return true;
            else
                return false;
        }
        internal bool czyTrojkatJestRozwartokatny()
        {

            double alpha = Math.Acos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c));
            double gamma = Math.Acos((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b));
            double beta = Math.Acos((Math.Pow(c, 2) + Math.Pow(a, 2) - Math.Pow(b, 2)) / (2 * a * c));
            alpha = alpha * 180 / Math.PI;
            gamma = gamma * 180 / Math.PI;
            beta = beta * 180 / Math.PI;
            if (alpha > 90 || gamma > 90 || beta > 90)
                return true;
            else
                return false;

        }
    }
}
