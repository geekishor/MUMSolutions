using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumber_Henry
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = henry(1, 3);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int henry(int i, int j)
        {
            int henry = 0;
            int max = Int32.MaxValue;
            int perfectCount = 0;

            for (int number = 1; number <= max; number++)
            {
                int sum = 0;
                for (int divider = 1; divider < number; divider++)
                {
                    if (number % divider == 0)
                    {
                        sum += divider;
                    }
                }
                if (sum == number)
                {
                    perfectCount++;
                    if (perfectCount == i)
                    {
                        henry += sum;
                    }
                    else if (perfectCount == j)
                    {
                        henry += sum;
                        break;
                    }
                }
            }
            return henry;
        }
    }
}
