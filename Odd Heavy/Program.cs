using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Heavy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isOddHeavy(new int[] { }));
            Console.WriteLine(isOddHeavy(new int[] { 11, 4, 9, 2, 8 }));
            Console.WriteLine(isOddHeavy(new int[] { 11, 4, 9, 2, 3, 10 }));
            Console.WriteLine(isOddHeavy(new int[] { 1 }));
            Console.WriteLine(isOddHeavy(new int[] { 2 }));
            Console.WriteLine(isOddHeavy(new int[] { 1, 1, 1, 1, 1, 1 }));
            Console.WriteLine(isOddHeavy(new int[] { 2, 4, 6, 8, 11 }));
            Console.WriteLine(isOddHeavy(new int[] { -2, -4, -6, -8, -11 }));

            Console.ReadLine();
        }

        private static int isOddHeavy(int[] a)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    count++;
                    break;
                }
            }
            if (count > 0)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] % 2 != 0)
                    {
                        for (int j = 0; j < a.Length; j++)
                        {
                            if (a[j] % 2 == 0)
                            {
                                if (a[i] > a[j])
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
                }
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
