using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bean_Array_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isBeanArray(new int[] { 2, 10, 9, 3,1,1,1,1,11,4,4 }));
            Console.WriteLine(isBeanArray(new int[] { 2, 2, 3, 3, 3 }));
            Console.WriteLine(isBeanArray(new int[] { 1, 1, 1, 2, 1, 1 }));
            Console.WriteLine(isBeanArray(new int[] { 0, -1, 1,0,0 }));

            Console.WriteLine(isBeanArray(new int[] { 3, 4, 5, 7 }));
            Console.WriteLine(isBeanArray(new int[] { 4, 7, 16 }));
            Console.WriteLine(isBeanArray(new int[] { 4, 56, 126,34,343,3432 }));

            Console.ReadLine();
        }
        public static int isBeanArray(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    count++;
                    if (arr[i] == arr[j] + 1 || arr[i] == arr[j] - 1)
                    {
                        break;
                    }
                    if (count == arr.Length)
                    {
                        return 0;
                    }
                }
            }
            return 1;
        }
    }
}
