using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decode_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(decodeArray(new int[] { 0, -3, 0, -4, 0 }));
            Console.WriteLine(decodeArray(new int[] { -1, 5, 8, 17, 15 }));
            Console.WriteLine(decodeArray(new int[] { 1, 5, 8, 17, 15 }));
            Console.WriteLine(decodeArray(new int[] {111, 115, 118, 127, 125}));
            Console.WriteLine(decodeArray(new int[] { 1,1 }));


            Console.ReadLine();
        }
        private static int decodeArray(int[] a)
        {
            string concat = string.Empty;
            for (int i = 0; i < a.Length - 1; i++)
            {
                int sum = a[i] - a[i + 1];
                if (sum < 0)
                {
                    sum = -sum;
                }
                
                concat += sum.ToString();
            }
            if (a[0] < 0)
            {
                concat = "-" + concat;
            }
            return Convert.ToInt32(concat);
        }
    }
}
