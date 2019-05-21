using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascal_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isPascal(15));
            Console.WriteLine(isPascal(6));
            Console.WriteLine(isPascal(7));
            Console.WriteLine(isPascal(16));

            Console.ReadLine();
        }

        public static int isPascal(int num)
        {
            int result = 0;
            int i = 1;
            do
            {
                result += i;
                if (result == num)
                {
                    return 1;
                }
                if (result > num)
                {
                    return 0;
                }
                i++;
            } while (true);
        }
    }
}
