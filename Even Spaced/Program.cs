using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Spaced
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isEvenSpaced(new int[] { 100, 19, 131, 140 }));
            Console.WriteLine(isEvenSpaced(new int[] { 200, 1, 151, 160 }));
            Console.WriteLine(isEvenSpaced(new int[] { 200, 10, 151, 160 }));
            Console.WriteLine(isEvenSpaced(new int[] { 100, 19, -131, -140 }));
            Console.WriteLine(isEvenSpaced(new int[] { 80, -56, 11, -81 }));

            Console.ReadLine();
        }

        public static int isEvenSpaced(int[] arr)
        {
            if (arr.Length < 2)
            {
                return 0;
            }
            int max = arr[0];
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
                if(arr[i] < min)
                {
                    min = arr[i];
                }
            }
            if ((max - min) % 2 == 0)
            {
                return 1;
            }
            return 0;
        }
    }
}
