using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meera_Array_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isMeera(new int[] { 4, 8, 6, 3, 2, 9, 8, 11, 8, 13, 12, 12, 6 }));
            Console.WriteLine(isMeera(new int[] { 2, 4, 6, 8, 6 }));
            Console.WriteLine(isMeera(new int[] { 2, 8, 7, 10, -4, 6 }));
            Console.WriteLine(isMeera(new int[] { 3, 3, 3, 7, 7, 7, 7, 7, 9, 9, 9, 9 }));
            Console.ReadLine();
        }
        public static int isMeera(int[] arr)
        {

            int beginCount = 0;
            int endCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    break;
                }
                beginCount++;
            }

            for (int i = arr.Length - 1; i > 0; i--)
            {

                if (arr[i] % 2 != 0)
                {
                    break;
                }
                endCount++;
            }

            if (beginCount == endCount && beginCount != 0 && beginCount != arr.Length)
            {
                return 1;
            }

            return 0;
        }
    }
}
