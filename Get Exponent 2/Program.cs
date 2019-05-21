using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Exponent_2
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

        public static int getExponent(int n, int p)
        {
            int power = 0;
            int max = 0;
            if (p <= 1)
            {
                return -1;
            }
            do
            {
                int divisor = calculatePower(p, power);
                if (n % divisor == 0)
                {
                    max = power;
                }
                else { break; }
                power++;
            } while (true);

            return max;
        }

        public static int calculatePower(int p, int power)
        {
            int result = 1;
            for (int i = power; i > 0; i--)
            {
                result = result * p;
            }
            return result;
        }
    }
}
