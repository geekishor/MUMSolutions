using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Safe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isSumSafe(new int[] { 5, -5, 0}));
            Console.WriteLine(isSumSafe(new int[] { 5, -2, 1 }));

            Console.ReadLine();
        }
        public static int isSumSafe(int[] a)
        {
            int sum = 0;
            for(int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            for(int i = 0; i < a.Length; i++)
            {
                if(sum == a[i])
                {
                    return 0;
                }
                else
                {
                    continue;
                }
            }
            return 1;
        }
    }
}
