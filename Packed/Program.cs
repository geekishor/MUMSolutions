using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packed
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(isPacked(new int[] { 2, 2, 3, 3, 3 }));
            //Console.WriteLine(isPacked(new int[] { 2, 3, 2, 3, 3 }));
            //Console.WriteLine(isPacked(new int[] { 2, 2, 2, 3, 3, 3 }));
            Console.WriteLine(isPacked(new int[] { 2, 2, 1 }));
            Console.WriteLine(isPacked(new int[] { 2, 2, 1, 2, 2 }));
            Console.WriteLine(isPacked(new int[] { 4, 4, 4, 4, 1, 2, 2, 3, 3, 3 }));
            Console.WriteLine(isPacked(new int[] { 7, 7, 7, 7, 7, 7, 7, 1 }));
            Console.WriteLine(isPacked(new int[] { 7, 7, 7, 7, 1, 7, 7, 7 }));
            Console.WriteLine(isPacked(new int[] { 7, 7, 7, 7, 7, 7, 7 }));
            Console.WriteLine(isPacked(new int[] { 1, 2, 1 }));
            Console.WriteLine(isPacked(new int[] { 2, 1, 1 }));
            Console.WriteLine(isPacked(new int[] { -3, -3, -3 }));
            Console.WriteLine(isPacked(new int[] { 0, 2, 2 }));
            Console.WriteLine(isPacked(new int[] { 2, 1, 2 }));
            Console.WriteLine(isPacked(new int[] { }));



            Console.ReadLine();
        }

        private static int isPacked(int[] a)
        {
            int arrayCount = 0;
            int loopCount = 0;
            List<int> list = new List<int>();

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

                foreach (int arrayItem in a)
                {
                    if (eachFinalItem == arrayItem)
                    {
                        count++;
                    }
                }
                loopCount += eachFinalItem;
                if (count == eachFinalItem)
                {
                    for (int i = arrayCount; i < loopCount; i++, arrayCount++)
                    {
                        if (eachFinalItem != a[i])
                        {
                            return 0;
                        }
                    }
                }
                else
                {
                    return 0;
                }
            }

            return 1;
        }
    }
}
