using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _121_Array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(is121Array(new int[] { 1, 2, 1 }));
            Console.WriteLine(is121Array(new int[] { 1, 1, 2, 2, 1, 1, }));
            Console.WriteLine(is121Array(new int[] { 1, 1, 2, 2, 1, 1, 1 }));
            Console.WriteLine(is121Array(new int[] { 1, 1, 1, 2, 2, 2, 1, 1, 1, 3 }));

            Console.WriteLine(is121Array(new int[] { 1, 1, 1, 1, 1 }));
            Console.WriteLine(is121Array(new int[] { 2, 2, 2, 1, 1, 1, 2, 2, 2, 1, 1 }));
            Console.WriteLine(is121Array(new int[] { 1, 1, 1, 2, 2, 2, 1, 1, 2, 2 }));
            Console.WriteLine(is121Array(new int[] { 2, 2, 2 }));
            Console.WriteLine(is121Array(new int[] { 1, 1, 2, 1, 2, 1, 1 }));

            Console.ReadLine();
        }
        public static int is121Array(int[] arr)
        {
            int firstCount = 0;
            int lastCount = 0;
            if (arr[0] != 1 || arr[arr.Length - 1] != 1)
            {
                return 0;
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == 1)
                {
                    firstCount++;
                }
                else { break; }
            }
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == 1)
                {
                    lastCount++;
                }
                else { break; }
            }
            if (firstCount == lastCount)
            {
                for (int i = firstCount; i <= arr.Length-1- lastCount; i++)
                {
                    if (arr[i] != 2)
                    {
                        return 0;
                    }
                }
            }
            else
            {
                return 0;
            }
            return 1;
        }
    }
}
