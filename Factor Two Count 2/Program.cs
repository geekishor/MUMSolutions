using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factor_Two_Count_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorTwoCount(48));
            Console.WriteLine(factorTwoCount(24));
            Console.WriteLine(factorTwoCount(7));
            Console.WriteLine(factorTwoCount(27));
            Console.ReadLine();
        }
        public static int factorTwoCount(int n)
        {
            int count = 0;
            do
            {
                if (n % 2 == 0)
                {
                    count++;
                    n = n / 2;
                }
                else
                {
                    return 0;
                }
            } while (n % 2 != 1);
            return count;
        }
    }
}
