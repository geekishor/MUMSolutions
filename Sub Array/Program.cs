using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isSub(new int[] { 13, 6, 3, 2 }));
            Console.WriteLine(isSub(new int[] { 11, 5, 3, 2 }));

            Console.ReadLine();
        }

        public static int isSub(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int sum = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    sum += arr[j];
                }

                if (sum >= arr[i])
                {
                    return 0;
                }
            }
            return 1;
        }
    }
}
