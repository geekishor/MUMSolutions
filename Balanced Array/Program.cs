using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balanced_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isBunker(new int[] { -2, 3, 2, -3 }));
            Console.WriteLine(isBunker(new int[] { -2, 2, 2, 2 }));
            Console.WriteLine(isBunker(new int[] { -5, 2, -2 }));
            Console.ReadLine();
        }
        public static int isBunker(int[] arr)
        {
            int indexCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < 0)
                    {
                        if (-arr[i] == arr[j])
                        {
                            indexCount++;
                            break;
                        }
                    }
                    else
                    {
                        if (-arr[i] == arr[j])
                        {
                            indexCount++;
                            break;
                        }
                    }
                }
            }
            if (indexCount < arr.Length)
            {
                return 0;
            }
            return 1;
        }
    }
}
