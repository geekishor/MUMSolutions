using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hollow_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isHollow(new int[] { 1, 2, 4, 0, 0, 0, 3, 4, 5 }));
            Console.WriteLine(isHollow(new int[] { 1, 2, 4, 9, 0, 0, 0, 3, 4, 5 }));
            Console.WriteLine(isHollow(new int[] { 1, 2, 0, 0, 3, 4 }));
            Console.WriteLine(isHollow(new int[] { 1, 2, 0}));
            Console.ReadLine();
        }
        public static int isHollow(int[] arr)
        {
            int indexCount = 0;
            int firstCount = 0;
            int zeroCount = 0;
            int lastCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    break;
                }
                firstCount++;
                indexCount++;
            }

            for (int i = indexCount; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    break;
                }
                indexCount++;
                zeroCount++;
            }
            if (!(zeroCount >= 3))
            {
                return 0;
            }

            for (int i = indexCount; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    break;
                }
                lastCount++;
            }
            if (lastCount == firstCount)
            {
                return 1;
            }
            return 0;
        }
    }
}
