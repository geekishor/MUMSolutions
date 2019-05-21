using System;

namespace Bunker_Array_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isBunker(new int[] { 7, 6, 10, 1}));
            Console.WriteLine(isBunker(new int[] { 7, 6, 10}));
            Console.WriteLine(isBunker(new int[] { 6, 10, 1}));
            Console.ReadLine();
        }
        public static int isBunker(int[] arr)
        {
            if (isPrime(arr))
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

        private static bool isPrime(int[] arr)
        {

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
                    return true;
                }
            }
            return false;
        }
    }
}
