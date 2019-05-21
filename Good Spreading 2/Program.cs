using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Good_Spreading_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isGoodSpreading(new int[] { 2, 1, 2, 5, 2, 1, 5, 9 }));
            Console.WriteLine(isGoodSpreading(new int[] { 3, 1, 3, 1, 3, 5, 5, 3 }));

            Console.ReadLine();
        }
        public static int isGoodSpreading(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (count > 3)
                {
                    return 0;
                }
            }
            return 1;
        }
    }
}
