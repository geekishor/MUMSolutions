using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Factor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sumFactor(new int[] { 1, -1, 1, -1, 1, -1, 1 }));
            Console.WriteLine(sumFactor(new int[] { 3, 0, 2, -5, 0 }));
            Console.WriteLine(sumFactor(new int[] { 9, -3, -3, -1, -1 }));
            Console.WriteLine(sumFactor(new int[] { 1 }));
            Console.WriteLine(sumFactor(new int[] { 0, 0, 0 }));
            Console.ReadLine();
        }
        public static int sumFactor(int[] a)
        {
            int sum = 0;
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == sum)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
