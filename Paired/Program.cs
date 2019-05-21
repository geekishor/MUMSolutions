using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paired
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isPaired(new int[] { 7, 2, 3, 6, 7 }));
            Console.WriteLine(isPaired(new int[] {7, 15, 9, 2, 3 }));
            Console.WriteLine(isPaired(new int[] { 17, 6, 2, 4 }));
            Console.WriteLine(isPaired(new int[] { 7  }));
            //  Console.WriteLine(isPaired(new int[] { 7, 2, 3, 6, 7 }));

            Console.ReadLine();
        }
        public static int isPaired(int[] arr)
        {
            if (arr.Length == 0) return 0;
            bool isNotEven = false;
            bool isNotOdd = false;

            for (int i = 0; i < arr.Length;)
            {
                if (arr[i] % 2 != 1)
                {
                    isNotEven = true;
                    break;
                }
                i += 2;
            }

            for (int i = 1; i < arr.Length;)
            {
                if (arr[i] % 2 != 0)
                {
                    isNotOdd = true;
                    break;
                }
                i += 2;
            }

            if (!isNotEven && !isNotOdd)
                return 1;
            return 0;
        }
    }
}
