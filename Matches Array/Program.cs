using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matches_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(matches(new int[] { 1, 2, 3, -5, -5, 2, 3, 18 }, new int[] { 3, -2, 3 }));
            Console.WriteLine(matches(new int[] { 1, 2, 3, -5, -5, 2, 3, 18 }, new int[] { 4, -1, 3 }));
            Console.WriteLine(matches(new int[] { 1, 2, 3, -5, -5, 2, 3, 18 }, new int[] { 3, -3, 3 }));
            Console.WriteLine(matches(new int[] { 1, 2, 3, -5, -5, 2, 3, 18 }, new int[] { 8 }));
            Console.ReadLine();
        }
        public static int matches(int[] A, int[] P)
        {
            int k = 0;
            int p = 0;
            for (int i = 0; i < P.Length; i++)
            {
                p += Math.Abs(P[i]);
                for (int j = k; j < Math.Abs(p); j++, k++)
                {
                    if (P[i] >= 0)
                    {
                        if (A[j] > 0)
                        {
                            continue;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        if (A[j] < 0)
                        {
                            continue;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
            return 1;
        }
    }
}
