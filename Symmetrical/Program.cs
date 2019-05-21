using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symmetrical
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isSymm(new int[] { 2, 7, 9, 10, 11, 5, 8 }));
            Console.WriteLine(isSymm(new int[] { 9, 8, 7, 13, 14, 17 }));
            Console.WriteLine(isSymm(new int[] { 2, 7, 8, 9, 11, 13, 10 }));
            Console.WriteLine(isSymm(new int[] { 2, 3 }));
            Console.WriteLine(isSymm(new int[] { 2 }));
            Console.WriteLine(isSymm(new int[] { 2, 3, 2 }));
            Console.WriteLine(isSymm(new int[] { }));

            Console.ReadLine();
        }

        public static int isSymm(int[] arr)
        {
            if (arr.Length == 0)
            {
                return 0;
            }
            int median = arr.Length / 2;
            int i = 0;
            int j = arr.Length - 1;
            for (; i < median; i++)
            {
                for (; j >= median;)
                {
                    if (arr[i] % 2 == arr[j] % 2)
                    {
                        j--;
                        break;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            return 1;
        }
    }
}
