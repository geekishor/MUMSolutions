using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Adjacent_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isLargestAdjacentSum(new int[] { 1, 2, 3, 4 }));
            Console.WriteLine(isLargestAdjacentSum(new int[] { 18, -12, 9, -10 }));
            Console.WriteLine(isLargestAdjacentSum(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
            Console.WriteLine(isLargestAdjacentSum(new int[] { 1, 1, 1, 1, 1, 2, 1, 1, 1 }));

            Console.ReadLine();
        }

        private static int isLargestAdjacentSum(int[] a)
        {
            if (a.Length < 2)
            {
                return 0;
            }
            int maxVal = 0;
            int sum = 0;
            for (int i = 0; i < a.Length-1; i++)
            {
                sum = a[i] + a[i + 1];
                if (sum > maxVal)
                {
                    maxVal = sum;
                }
            }
            return maxVal;
        }
    }
}
