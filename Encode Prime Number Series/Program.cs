using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encode_Prime_Number_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = encodeNumber(24);
            Console.Write("{" + String.Join(",", result.ToArray()) + "}");
            Console.ReadLine();
        }

        private static List<int> encodeNumber(int n)
        {
            List<int> list = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    if (isPrime(i))
                    {
                        n = n / i;
                        list.Add(i);
                        i = 1;
                    }
                }
            }
            return list;
        }

        private static bool isPrime(int n)
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
            else
            {
                return false;
            }

        }
    }
}
