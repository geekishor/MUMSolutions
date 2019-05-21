using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fill_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Array arr = fill(new int[] { 4, 2, -3, 12 }, 1, 5);
            Array arr2 = fill(new int[] { 1, 2, 3, 5, 9, 12, -2, -1 }, 3, 10);
            Array arr3 = fill(new int[] { 2, 6, 9, 0, -3 }, 0, 4);
           
            Console.Read();
        }
        public static int[] fill(int[] arr, int k, int n)
        {
            int[] arr2 = new int[n];
            if (k <= 0 || n <= 0)
                return null;

            for (int i = 0; i < n; i++)
            {
                if (i < k)
                    arr2[i] = arr[i];
                else
                    arr2[i] = arr2[i - k];
            }
            return arr2;
        }
    }
}
