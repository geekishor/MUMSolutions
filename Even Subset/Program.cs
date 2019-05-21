using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Subset
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isEvenSpaced(18, 12));
            Console.WriteLine(isEvenSpaced(18, 32));
            Console.WriteLine(isEvenSpaced(19, 32));
            Console.WriteLine(isEvenSpaced(13, 15));
            Console.ReadLine();
        }
        public static int isEvenSpaced(int m, int n)
        {
            if (m % 2 != 0)
            {
                return 0;
            }
            for (int i = 2; i < m ; i++)
            {
                if (m % i == 0 && i % 2 == 0)
                {
                    if (n % i != 0)
                    {
                        return 0;
                    }
                }
            }
            return 1;
        }
    }
}
