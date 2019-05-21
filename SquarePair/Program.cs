using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquarePair
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(countSquarePair(new int[] { 11, 5, 4, 20 }));
            Console.WriteLine(countSquarePair(new int[] { 9, 0, 2, -5, 7 }));
            Console.WriteLine(countSquarePair(new int[] { 9 }));
            Console.ReadLine();

        }
        public static int countSquarePair(int[] arr)
        {
            int count = 0;
            if (arr.Length <= 1)
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] > 0 && arr[j] > 0)
                        {
                            int sum = arr[i] + arr[j];
                            int square = (int)Math.Sqrt(sum);
                            if (sum == square * square)
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            return count;
        }

    }
}
