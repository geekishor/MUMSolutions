using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meera_Array_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isMeera(new int[] { 7, 9, 0, 10, 1 }));
            Console.WriteLine(isMeera(new int[] { 6, 10, 8 }));
            Console.WriteLine(isMeera(new int[] { 7, 6, 1 }));
            Console.WriteLine(isMeera(new int[] { 9, 10, 0 }));
            Console.WriteLine(isMeera(new int[] { 1, 1, 0, 8, 0, 9, 9, 1 }));

            Console.ReadLine();
        }
        public static int isMeera(int[] arr)
        {
            bool containsOne = false;
            bool containsNine = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 9)
                {
                    containsNine = true;
                }
                else if (arr[i] == 1)
                {
                    containsOne = true;
                }
            }
            if (containsOne == containsNine)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
