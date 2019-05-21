using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuff_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isStuffArray(new int[] { 2, 10, 9, 3 }));
            Console.WriteLine(isStuffArray(new int[] { 2, 2, 3, 3, 3 }));
            Console.WriteLine(isStuffArray(new int[] { 1, 1, 1, 2, 1, 1 }));
            Console.WriteLine(isStuffArray(new int[] { 0, -1, 1 }));
            Console.WriteLine(isStuffArray(new int[] { 3, 4, 5, 7 }));

            Console.ReadLine();
        }

        public static int isStuffArray(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] + 1 || arr[i] == arr[j] - 1)
                    {
                        count++;
                        break;
                    }
                }
            }
            if (count == arr.Length)
            {
                return 1;
            }
            return 0;
        }
    }
}
