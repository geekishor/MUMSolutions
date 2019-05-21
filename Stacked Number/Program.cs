using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacked_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isStacked(1));
            Console.WriteLine(isStacked(3));
            Console.WriteLine(isStacked(6));
            Console.WriteLine(isStacked(10));
            Console.WriteLine(isStacked(15));
            Console.WriteLine(isStacked(9));
            Console.WriteLine(isStacked(2));
            Console.WriteLine(isStacked(8));
            Console.WriteLine(isStacked(11));
            Console.WriteLine(isStacked(14));
            Console.WriteLine(isStacked(13));
            Console.WriteLine(isStacked(12));
            Console.ReadLine();
        }
        
        public static int isStacked(int n)
        {
            int sum = 0;
            for(int i = 1; i < Int16.MaxValue; i++)
            {
                sum += i;
                if(sum == n)
                {
                    return 1;
                }
                else if(sum > n)
                {
                    return 0;
                }
            }
            return 0;
        }
    }
}
