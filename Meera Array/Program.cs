using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meera_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isGoodSpreading(new int[] { 4, 8, 6, 3, 2, 9, 8, 11, 8, 13, 12, 12, 6 }));
            Console.WriteLine(isGoodSpreading(new int[] { 4, 3, 2 }));
            Console.WriteLine(isGoodSpreading(new int[] { 4, 3 }));
            Console.WriteLine(isGoodSpreading(new int[] { 5 }));
            Console.WriteLine(isGoodSpreading(new int[] { 2, 4, 6, 8, 6 }));
            Console.WriteLine(isGoodSpreading(new int[] { 2, 8, 7, 10, -4, 6 }));
            Console.WriteLine(isGoodSpreading(new int[] { 5,4}));
            Console.WriteLine(isGoodSpreading(new int[] { 7,4,9}));
            Console.ReadLine();
        }
        public static int isGoodSpreading(int[] arr)
        {
            if (ContainsOdd(arr))
            {
                int index = 0;
                int count = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        index++;
                    }
                    else
                    {
                        break;
                    }
                }

                for (int i = arr.Length - 1; (i > arr.Length - index - 2 && i >= arr.Length / 2); i--)
                {
                    if (arr[i] % 2 == 0)
                    {
                        count++;
                    }
                }
                if (count != index)
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
            return 1;
        }

        private static bool ContainsOdd(int[] arr)
        {
            foreach (int item in arr)
            {
                if (item % 2 == 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
