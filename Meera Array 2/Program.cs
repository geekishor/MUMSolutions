using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meera_Array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isMeera(new int[] { 3, 5, -2 }));
            Console.WriteLine(isMeera(new int[] { 8, 3, 4 }));
            Console.ReadLine();
        }
        public static int isMeera(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (2 * arr[i] == arr[j])
                    {
                        return 0;
                    }
                }
            }
            return 1;
        }
    }
}
