using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_Divisible
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isDivisible(new int[] { 3, 3, 6, 36 }, 3));
            Console.WriteLine(isDivisible(new int[] { 4 }, 2));
            Console.WriteLine(isDivisible(new int[] { 3, 4, 3, 6, 36 }, 3));
            Console.WriteLine(isDivisible(new int[] { 6, 12, 24, 36 }, 12));
            Console.WriteLine(isDivisible(new int[] { }, 9));
            Console.ReadLine();
        }
        public static int isDivisible(int[] a, int divisor)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % divisor == 0)
                {
                    count++;
                }
            }
            if (count == a.Length)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
