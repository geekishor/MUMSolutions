using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_Zeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(arrayHasNoZeros(new int[] { 1, 2, 3 }));
            Console.WriteLine(arrayHasNoZeros(new int[] { 1, 0, 4, 0 }));
            Console.WriteLine(arrayHasNoZeros(new int[] { 1, 2, 3, 0 }));
            Console.WriteLine(arrayHasNoZeros(new int[] { 0, 0, 0, 0 }));
            Console.WriteLine(arrayHasNoZeros(new int[] { }));
            Console.ReadLine();
        }
        public static int arrayHasNoZeros(int[] a)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0)
                {
                    count++;
                }
            }
            if (count == a.Length)
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
