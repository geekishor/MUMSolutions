using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bean_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isBeanArray(new int[] { 4, 9, 8 }));
            Console.WriteLine(isBeanArray(new int[] { 2, 2, 5, 11, 23 }));
            Console.WriteLine(isBeanArray(new int[] { 7, 7, 3, 6 }));
            Console.WriteLine(isBeanArray(new int[] { 0 }));
            Console.WriteLine(isBeanArray(new int[] { 3, 8, 4 }));

            Console.ReadLine();
        }
        public static int isBeanArray(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == 2 * arr[j] || arr[i] == 2 * arr[j] + 1 || arr[i] == arr[j] / 2)
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
            else
            {
                return 0;
            }
        }
    }
}
