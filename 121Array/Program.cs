using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _121Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(is121Array(new int[] { 1, 2, 1 }));
            Console.WriteLine(is121Array(new int[] { 1, 1, 2, 2, 2, 1, 1 }));
            Console.WriteLine(is121Array(new int[] { 1, 1, 2, 2, 2, 1, 1, 1 }));
            Console.WriteLine(is121Array(new int[] { 1, 1, 2, 1, 2, 1, 1 }));
            Console.WriteLine(is121Array(new int[] { 1, 1, 1, 2, 2, 2, 1, 1, 1, 3 }));
            Console.WriteLine(is121Array(new int[] { 1, 1, 1, 1, 1, 1 }));
            Console.WriteLine(is121Array(new int[] { 2, 2, 2, 1, 1, 1, 2, 2, 2, 1, 1 }));
            Console.WriteLine(is121Array(new int[] { 1, 1, 1, 2, 2, 2, 1, 1, 2, 2 }));
            Console.WriteLine(is121Array(new int[] { 2, 2, 2 }));

            Console.ReadLine();
        }

        private static int is121Array(int[] a)
        {
            if (a[0] != 1)
            {
                return 0;
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 1 && a[i] != 2)
                {
                    return 0;
                }
            }
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 1)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            if (count == a.Length)
            {
                return 0;
            }
            for (int i = a.Length - 1; i >= a.Length - count; i--)
            {
                if (a[i] != 1)
                {
                    return 0;
                }
            }
            for (int i = count; i < a.Length - count; i++)
            {
                if (a[i] != 2)
                {
                    return 0;
                }
            }
            return 1;
        }
    }
}

