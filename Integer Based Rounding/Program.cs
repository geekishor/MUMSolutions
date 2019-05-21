using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_Based_Rounding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(doIntegerBasedRouding(new int[] { 1, 2, 3, 4, 5, 101, 139 }, 5));
            Console.WriteLine(doIntegerBasedRouding(new int[] { -18, 1, 2, 3, 4, 5 }, 4));
           

            Console.ReadLine();
        }
        private static List<int> doIntegerBasedRouding(int[] a, int n)
        {
            List<int> list = new List<int>();
            
            for (int i = 0; i < a.Length; i++)
            {
                if (n <= 0)
                    break;
                else if (a[i] > 0)
                {
                    int temp1 = (a[i] / n) * n;
                    int temp2 = temp1 + n;
                    list.Add ( ((temp2 - a[i]) > (a[i] - temp1)) ? temp1 : temp2);
                }
            }
            return list;
        }
    }
}
