using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorcupineNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(findPorcupineNumber(n));
            Console.ReadLine();
        }
        public static int findPorcupineNumber(int n)
        {
            do
            {
                int firstPrimeNumber = FindNextPrimeNumber(n);
                n++;
                if (firstPrimeNumber % 10 == 9)
                {
                    do
                    {
                        int secondNextPrimeNumber = FindNextPrimeNumber(firstPrimeNumber);
                        firstPrimeNumber++;
                        if (secondNextPrimeNumber % 10 == 9)
                        {
                            return firstPrimeNumber - 1;
                        }
                        else
                        {
                            break;
                        }
                    } while (true);
                }
            } while (true);
        }

        public static bool isPrimeNumber(int n)
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
            else { return false; }
        }

        public static int FindNextPrimeNumber(int n)
        {
            try
            {
                int number = 0;
                do
                {
                    number = n + 1;
                    bool isPrime = isPrimeNumber(number);

                    if (isPrime)
                    {
                        return number;
                    }
                    n++;
                } while (true);
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}
