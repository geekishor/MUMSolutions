using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeeraArray6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isMeera(new int[] { 7, 6, 0, 10, 1 }));
            Console.WriteLine(isMeera(new int[] { 6, 10, 1 }));
            Console.WriteLine(isMeera(new int[] { 7, 6, 10 }));
            Console.WriteLine(isMeera(new int[] { 6, 10, 0 }));
            Console.ReadLine();
        }
        public static int isMeera(int[] arr)
        {
            bool hasPrime = false;
            int zeroCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    zeroCount++;
                }
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
                    hasPrime = true;
                }
            }

            if ((hasPrime && zeroCount > 0) || (!hasPrime && zeroCount == 0))
            {
                return 1;
            }
            return 0;
        }
    }
}
