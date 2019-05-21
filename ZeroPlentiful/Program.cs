using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroPlentiful
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isZeroPlentiful(new int[] { 0, 0, 0, 0, 0 }));
            Console.ReadLine();
        }
        public static int isZeroPlentiful(int[] a)
        {
            int iCount = 0;

            for (int i = iCount; i < a.Length; iCount++)
            {
                int count = 0;
                if (a[iCount] == 0)
                {
                    for (int j = iCount + 1; j < iCount + 4; j++)
                    {
                        iCount++;
                        if (a[iCount] == a[j])
                        {
                            count++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return 0;
        }
    }
}
