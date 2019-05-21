using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digit_Increasing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isDigitIncreasing(24));
            Console.ReadLine();
        }
        public static int isDigitIncreasing(int num)
        {
            int n = num;
            int count = 0;
            do
            {
                n = n / 10;
                count++;

            } while (n != 0);

            if (count == 1)
            {
                return 1;
            }
            for (int i = 1; i <= 9; i++)
            {
                for(int j = i; j<=count; j++)
                {

                }
            }


            return 1;
        }

    }
}
