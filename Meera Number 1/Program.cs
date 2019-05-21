using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meera_Number_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isMeera(6));
            Console.WriteLine(isMeera(30));
            Console.WriteLine(isMeera(21));
            Console.WriteLine(isMeera(20));
            Console.ReadLine();
        }
        public static int isMeera(int n)
        {
            int count = 0;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (n % count == 0)
            {
                return 1;
            }
            else
            return 0;
        }
    }
}
