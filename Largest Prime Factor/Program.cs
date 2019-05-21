using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Prime_Factor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(largestPrimeFactor(10));
            Console.WriteLine(largestPrimeFactor(6936));
            Console.WriteLine(largestPrimeFactor(1));

            Console.ReadLine();
        }

        private static int largestPrimeFactor(int n)
        {
            int max = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    bool isprime = isPrime(i);
                    if (isprime)
                    {
                        if (i > max)
                        {
                            max = i;
                        }
                    }
                }
            }
            return max;
        }
        public static bool isPrime(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                return true;
            }
            return false;
        }
    }
}
