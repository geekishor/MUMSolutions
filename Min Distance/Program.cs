using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(minDistance(63));
            Console.WriteLine(minDistance(25));
            Console.WriteLine(minDistance(11));
            Console.ReadLine();
        }
        public static int minDistance(int n)
        {
            int smallestDistance = n;
            bool containsFactor = false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    containsFactor = true;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (n % j == 0 && smallestDistance > (j - i))
                        {
                            smallestDistance = j - i;
                            break;
                        }

                    }
                }
            }
            if (smallestDistance == n)
            {
                if (containsFactor)
                    return 0;
                else
                    return -1;
            }
            return smallestDistance;

        }
    }
}
