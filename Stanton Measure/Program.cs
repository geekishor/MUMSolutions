using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stanton_Measure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(stantonMeasure(new int[] { 1, 4, 3, 2, 1, 2, 3, 2 }));
            Console.WriteLine(stantonMeasure(new int[] { 1 }));
            Console.WriteLine(stantonMeasure(new int[] { 0 }));
            Console.WriteLine(stantonMeasure(new int[] { 3, 1, 1, 4 }));
            Console.WriteLine(stantonMeasure(new int[] { 1, 3, 1, 1, 3, 3, 2, 3, 3, 3, 4 }));
            Console.WriteLine(stantonMeasure(new int[] { }));
            Console.ReadLine();
        }
        public static int stantonMeasure(int[] a)
        {
            int oneCount = 0;
            int sCount = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 1)
                {
                    oneCount++;
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == oneCount)
                {
                    sCount++;
                }
            }
            return sCount;
        }
    }
}
