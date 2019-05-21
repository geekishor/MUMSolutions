using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequenced_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isSequencedArray(new int[] { 2, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5 }, 2, 5));
            Console.WriteLine(isSequencedArray(new int[] { 1, 2, 3, 4, 5 }, 1, 5));
            Console.WriteLine(isSequencedArray(new int[] { 1, 3, 4, 2, 5 }, 1, 5));
            Console.WriteLine(isSequencedArray(new int[] { -5, -5, -4, -4, -4, -3, -3, -2, -2, -2 }, -5, -2));
            Console.WriteLine(isSequencedArray(new int[] { 0, 1, 2, 3, 4, 5 }, 1, 5));
            Console.WriteLine(isSequencedArray(new int[] { 1, 2, 3, 4 }, 1, 5));
            Console.WriteLine(isSequencedArray(new int[] { 1, 2, 5 }, 1, 5));
            Console.WriteLine(isSequencedArray(new int[] { 5, 4, 3, 2, 1 }, 1, 5));

            Console.ReadLine();
        }

        private static int isSequencedArray(int[] a, int m, int n)
        {

            if (a[0] != m || a[a.Length - 1] != n)
            {
                return 0;
            }
            for (int i = 0; i < a.Length - 2; i++)
            {
                if (a[i + 1] == m || a[i + 1] == m + 1)
                {
                    if (a[i + 2] != m)
                    {
                        if (a[i + 2] > a[i + 1] + 1)
                        {
                            return 0;
                        }
                        m++;
                    }
                    continue;
                }
                else
                {
                    return 0;
                }
            }
            return 1;
        }
    }
}
