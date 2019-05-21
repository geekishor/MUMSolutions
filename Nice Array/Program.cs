using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nice_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isNice(new int[] { 2, 10, 9, 3 }));
            Console.WriteLine(isNice(new int[] { 2, 2, 3, 3, 3 }));
            Console.WriteLine(isNice(new int[] { 1, 1, 1, 2, 1, 1 }));
            Console.WriteLine(isNice(new int[] { 0, -1, 1 }));
            Console.WriteLine(isNice(new int[] {  3, 4, 5, 7 }));

            Console.ReadLine();
        }
        public static int isNice(int[] arr)
        {
            int indexCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] + 1 || arr[i] == arr[j] - 1)
                    {
                        indexCount++;
                        break;
                    }
                }
            }
            if (indexCount == arr.Length)
            {
                return 1;
            }
            return 0;
        }
    }
}
