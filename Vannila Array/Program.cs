using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vannila_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isVannila(new int[] { 1, 1, 11, 1111, 1111111 }));
            Console.WriteLine(isVannila(new int[] { 11, 101, 1111, 11111 }));
           Console.WriteLine(isVannila(new int[] { 1 }));
            Console.WriteLine(isVannila(new int[] { 11, 22, 13, 34, 12 }));
            Console.WriteLine(isVannila(new int[] { 9, 999, 99999, -9999 }));
            Console.WriteLine(isVannila(new int[] { }));

            Console.ReadLine();
        }

        public static int isVannila(int[] arr)
        {
           // var allSame = arr.All(n => n.ToString().Distinct().Count() == 1);
            var isValid = arr.Select(a => a.ToString()).SelectMany(a => a).Distinct().Count() <= 1;
            if (isValid)
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
