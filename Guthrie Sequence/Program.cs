using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guthrie_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isGuthrieSequence(new int[] { 7, 22, 11, 34, 17, 52, 26, 13, 40, 20, 10, 5, 16, 8, 4, 2, 1 }));
            Console.WriteLine(isGuthrieSequence(new int[] { 8, 4, 2, 1 }));
            Console.WriteLine(isGuthrieSequence(new int[] { 8, 17, 4, 1 }));
            Console.WriteLine(isGuthrieSequence(new int[] { 8, 4, 1 }));
            Console.WriteLine(isGuthrieSequence(new int[] { 8, 4, 2 }));
            Console.ReadLine();
        }
        public static int isGuthrieSequence(int[] a)
        {
            if (a[0] > 0)
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (a[i] % 2 == 0)
                    {
                        int evenResult = a[i] / 2;
                        if (evenResult == a[i + 1])
                        {
                            if (i + 1 == a.Length - 1)
                            {
                                if (evenResult == 1)
                                {
                                    return 1;
                                }
                                else
                                {
                                    return 0;
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        int oddResult = (a[i] * 3) + 1;
                        if (oddResult == a[i + 1])
                        {
                            if (i + 1 == a.Length - 1)
                            {
                                if (oddResult == 1)
                                {
                                    return 1;
                                }
                                else
                                {
                                    return 0;
                                }
                            }
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
