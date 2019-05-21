using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunker_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isBunker(new int[] { 4, 9, 6, 7, 3 }));
            Console.WriteLine(isBunker(new int[] { 4, 9, 6, 15, 21 }));
            Console.ReadLine();
        }
        public static int isBunker(int[] arr)
        {
            
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    int count = 0;
                    for (int j = 1; j <= arr[i + 1]; j++)
                    {
                        if (arr[i + 1] % j == 0)
                        {
                            count++;
                        }
                    }
                    if (count == 2)
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }
    }
}
