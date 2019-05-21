using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Powerful
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isCubePowerful(153));
            Console.WriteLine(isCubePowerful(370));
            Console.WriteLine(isCubePowerful(371));
            Console.WriteLine(isCubePowerful(407));
            Console.WriteLine(isCubePowerful(87));
            Console.WriteLine(isCubePowerful(0));
            Console.WriteLine(isCubePowerful(-81));


            Console.ReadLine();
        }
        private static int isCubePowerful(int n)
        {
            if(n<= 0)
            {
                return 0;
            }
            int sum = 0;
            int temp = n;
            do
            {
                int number = temp % 10;
                sum += number * number * number;
                temp = temp / 10;
            } while (temp!= 0);
            if (sum == n)
            {
                return 1;
            }
            return 0;
        }
    }
}
