using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Min_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isMaxMin(new int[] { 11, 4, 9, 11, 8, 5, 4, 10 }));
            Console.WriteLine(isMaxMin(new int[] { }));
            Console.WriteLine(isMaxMin(new int[] { 2 }));
            Console.WriteLine(isMaxMin(new int[] { 1, 1, 1, 1, 1, 1 }));
            Console.WriteLine(isMaxMin(new int[] { 2, 4, 6, 8, 11 }));
            Console.WriteLine(isMaxMin(new int[] { -2, -4, -6, -8, -11 }));
            Console.ReadLine();
        }
        public static int isMaxMin(int[] arr)
        {
            int count = 0;
            int maxCount = 0;
            int minCount = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[0] != arr[i])
                {
                    count++;
                }
            }
            if (count >= 1)
            {
                int max = arr[0];
                int min = arr[0];

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == max)
                    {
                        maxCount++;
                    }
                    if (arr[i] == min)
                    {
                        minCount++;
                    }
                }
                if (maxCount == minCount)
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}
