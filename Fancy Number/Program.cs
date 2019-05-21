using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fancy_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isFancy(5));
            Console.WriteLine(isFancy(17));
            Console.WriteLine(isFancy(61));
            Console.WriteLine(isFancy(231));

            Console.ReadLine();
        }
        public static int isFancy(int n)
        {
            int i = 1;
            int j = 1;
            while (i < n)
            {
                int temp = j;
                j = 2 * i + 3 * j;
                i = temp;
                if (i == n)
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}
