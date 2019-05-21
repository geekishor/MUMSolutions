using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequentially_Bounded
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isSequentiallyBounded(new int[] { 2, 3, 3, 99, 99, 99, 99, 99 }));
            Console.WriteLine(isSequentiallyBounded(new int[] { 1, 2, 3 }));
            Console.WriteLine(isSequentiallyBounded(new int[] { 2, 3, 3, 3, 3 }));
            Console.WriteLine(isSequentiallyBounded(new int[] { 12, 12, 9 }));
            Console.WriteLine(isSequentiallyBounded(new int[] { 0, 1 }));
            Console.WriteLine(isSequentiallyBounded(new int[] { -1, 2 }));
            Console.WriteLine(isSequentiallyBounded(new int[] { }));
            Console.WriteLine(isSequentiallyBounded(new int[] { 5, 5, 5, 5 }));
            Console.WriteLine(isSequentiallyBounded(new int[] { 5, 5, 5, 2, 5 }));

            Console.ReadLine();
        }

        private static int isSequentiallyBounded(int[] a)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] <= a[i + 1])
                {
                    continue;
                }
                else
                {
                    return 0;
                }
            }
            foreach (int eachItem in a)
            {
                if (!list.Contains(eachItem))
                {
                    list.Add(eachItem);
                }
            }

            var finalArray = list.ToArray();
            foreach (int eachFinalItem in finalArray)
            {
                int count = 0;
                foreach (int eachArrayItem in a)
                {
                    if(eachArrayItem < 0)
                    {
                        return 0;
                    }

                    if (eachFinalItem == eachArrayItem)
                    {
                        count++;
                    }
                    if (count < eachFinalItem)
                    {
                        continue;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            return 1;
        }
    }
}
