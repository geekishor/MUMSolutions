using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Exponent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getExponent(162, 3));
            Console.WriteLine(getExponent(27, 3));
            Console.WriteLine(getExponent(28, 3));
            Console.WriteLine(getExponent(280, 7));
            Console.WriteLine(getExponent(-250, 5));
            Console.WriteLine(getExponent(18, 1));
            Console.WriteLine(getExponent(128, 4));


            Console.ReadLine();
        }

        private static int getExponent(int n, int p)
        {
            if (p <= 1)
            {
                return -1;
            }
            int max = 0;
            int power = 1;
            bool check = true;
            do
            {
                int divisor = calculatePower(p, power);
                if (n % divisor == 0)
                {
                    max = power;
                }
                else
                {
                    check = false;
                }
                power++;
            } while (check);
            return max;
        }
        public static int calculatePower(int p, int power)
        {
            int result = 1;
            for (int i = power; power > 0; power--)
            {
                result = result * p;
            }
            return result;
        }
    }
}
