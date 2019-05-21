using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isBunker(32121, 1));
            Console.WriteLine(isBunker(32121, 2));
            Console.WriteLine(isBunker(32121, 3));
            Console.WriteLine(isBunker(33331, 3));
            Console.WriteLine(isBunker(33331, 6));
            Console.WriteLine(isBunker(3, 3));
            Console.ReadLine();
        }
        public static int isBunker(int num, int n)
        {
            int count = 0;
            do
            {
                int digit = num % 10;
                if (digit == n)
                {
                    count++;
                }
                num = num / 10;
            }
            while (num != 0);
            return count;
        }
    }
}
