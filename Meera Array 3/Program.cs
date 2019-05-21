using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meera_Array_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isMeera(new int[] { 7, 6, 10, 1 }));
            Console.WriteLine(isMeera(new int[] { 7, 6, 10 }));
            Console.WriteLine(isMeera(new int[] { 3, 7, 1, 8 }));
            Console.WriteLine(isMeera(new int[] { 3, 7, 1, 8, 1 }));
            Console.ReadLine();
        }
        public static int isMeera(int[] arr)
        {
            bool check = false;

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 1; j <= arr[i]; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    check = true;
                    break;
                }

            }
            if (check)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 1)
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }
    }
}
