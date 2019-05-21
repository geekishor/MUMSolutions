using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Unique
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isNUnique(new int[] { 7, 3, 3, 2, 4 }, 6));
             Console.WriteLine(isNUnique(new int[] { 7, 3, 3, 2, 4 },10));
            Console.WriteLine(isNUnique(new int[] { 7, 3, 3, 2, 4 }, 11 ));
            Console.WriteLine(isNUnique(new int[] { 7, 3, 3, 2, 4 }, 8));
            Console.WriteLine(isNUnique(new int[] { 7, 3, 3, 2, 4 }, 4));
            Console.WriteLine(isNUnique(new int[] { 1 }, 4));
            Console.ReadLine();
        }
        public static int isNUnique(int[] arr, int n)
        {
            int count = 0;
            for(int i = 0; i<arr.Length-1; i++)
            {
                int sum = 0;
                for(int j=i+1; j < arr.Length; j++)
                {
                    sum = arr[i] + arr[j];
                    if (sum == n)
                    {
                        count++;
                    } 
                }
            }
            if(count == 1)
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
