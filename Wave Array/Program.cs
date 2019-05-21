using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isWave(new int[] { 7, 2, 9, 10, 5 }));
            Console.WriteLine(isWave(new int[] { 4, 11, 12, 1, 6 }));
            Console.WriteLine(isWave(new int[] { 1, 0, 5 }));
            Console.WriteLine(isWave(new int[] { 2 }));
            Console.WriteLine(isWave(new int[] { 2, 3 }));
            Console.WriteLine(isWave(new int[] { 2, 6, 3, 4 }));


            Console.ReadLine();
        }
        public static int isWave(int[] arr)
        {
            for(int i =0; i<arr.Length-1; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    if (arr[i + 1] % 2 == 0)
                    {
                        return 0;
                    }
                }
                else
                {
                    if (arr[i + 1] % 2 == 1)
                    {
                        return 0;
                    }
                }
            }
            return 1;
        }
    }
}
