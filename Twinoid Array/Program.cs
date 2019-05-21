using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twinoid_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isTwinoid(new int[] { 3, 3, 2, 6, 7 }));
            Console.WriteLine(isTwinoid(new int[] { 3, 3, 2, 6,6, 7 }));
            Console.WriteLine(isTwinoid(new int[] { 3, 3, 2, 7,6,7 }));
            Console.WriteLine(isTwinoid(new int[] { 3, 8,5,7,3 }));
            Console.ReadLine();
        }
        public static int isTwinoid(int[] arr)
        {
            int count = 0;
            bool isTwin = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && arr[i + 1] % 2 == 0)
                {
                    isTwin = true;
                    count++;
                }
                else if (arr[i] % 2 == 0)
                {
                    count++;
                }
            }
            if (isTwin && count == 2)
            {
                return 1;
            }
            return 0;
        }
    }
}
