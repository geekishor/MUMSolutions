using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibinacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1,1,2,3,5,8,13,21
            Console.WriteLine(isFibonnaci(21));
            Console.WriteLine(isFibonnaci(2));
            Console.WriteLine(isFibonnaci(3));
            Console.WriteLine(isFibonnaci(5));
            Console.WriteLine(isFibonnaci(8));
            Console.WriteLine(isFibonnaci(13));

            Console.WriteLine(isFibonnaci(6));
            Console.WriteLine(isFibonnaci(7));
            Console.WriteLine(isFibonnaci(9));
            Console.WriteLine(isFibonnaci(11));
            Console.WriteLine(isFibonnaci(12));



            Console.ReadLine();
        }
        public static int isFibonnaci(int n)
        {
            int i = 1;
            int j = 1;
            while (i < n)
            {
                int temp = j;
                j = i + j;
                i = temp;

                if(i == n)
                {
                    return 1;
                }
            }
            return 0;
        }

    }
}
