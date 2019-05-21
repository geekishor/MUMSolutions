using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bean_Array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isBeanArray(new int[] { 1, 2, 3, 9, 6, 13 }));
            Console.WriteLine(isBeanArray(new int[] { 3, 4, 6, 7, 13, 15 }));
            Console.WriteLine(isBeanArray(new int[] { 1, 2, 3, 4, 10, 11, 12 }));
            Console.WriteLine(isBeanArray(new int[] { 3, 6, 9, 5, 7, 13, 6, 1 }));
            Console.WriteLine(isBeanArray(new int[] { 9, 6, 18 }));
            Console.WriteLine(isBeanArray(new int[] { 4, 7, 16 }));
            Console.WriteLine(isBeanArray(new int[] { 4, 56, 126 }));

            Console.ReadLine();
        }
        public static int isBeanArray(int[] arr)
        {
            bool containsNine = false;
            bool containsThirteen = false;
            bool containSeven = false;
            bool containsSixteen = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 9)
                {
                    containsNine = true;
                }
                else if (arr[i] == 13)
                {
                    containsThirteen = true;
                }
                if (arr[i] == 7)
                {
                    containSeven = true;
                }
                else if (arr[i] == 16)
                {
                    containsSixteen = true;
                }
            }
            if ((containsNine == containsThirteen) && (containSeven == !containsSixteen))
                return 1;


            return 0;
        }
    }
}
