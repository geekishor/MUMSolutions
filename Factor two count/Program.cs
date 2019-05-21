using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factor_two_count
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorTwoCount(48));
            Console.WriteLine(factorTwoCount(24));
            Console.WriteLine(factorTwoCount(7));
            Console.WriteLine(factorTwoCount(27));
            Console.WriteLine(factorTwoCount(4));
            Console.ReadLine();
        }
        public static int factorTwoCount(int num)
        {
            int count = 0;
            //while (num % 2 == 0)
            //{
            //    count++;
            //    num = num / 2;
            //}

            do
            {
                if (num % 2 == 0)
                {
                    count++;
                    num = num / 2;
                }
                else
                {
                    break;
                }
            } while (true);
            return count;
        }
    }
}

