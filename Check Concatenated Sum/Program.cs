using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Concatenated_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(checkConcatenatedSum(198, 2));
            Console.WriteLine(checkConcatenatedSum(198, 3));
            Console.WriteLine(checkConcatenatedSum(2997, 3));
            Console.WriteLine(checkConcatenatedSum(2997, 2));
            Console.WriteLine(checkConcatenatedSum(13332, 4));
            Console.WriteLine(checkConcatenatedSum(9, 1));

            Console.ReadLine();
        }

        private static int checkConcatenatedSum(int n, int catlen)
        {
            int sum = 0;
            int number = n;
            do
            {
                int rem = number % 10;
                number = number / 10;
                string character = string.Empty;
                for (int i = 1; i <= catlen; i++)
                {
                    character += rem.ToString();
                }
                sum += Convert.ToInt32(character);
            } while (number != 0);
            if (sum == n)
            {
                return 1;
            }
            else
            {
                return 0;
            }


            //string number = n.ToString();
            //int sum = 0;

            //foreach (char item in number)
            //{
            //    string character = string.Empty;
            //    for (int i = 1; i <= catlen; i++)
            //    {
            //        character += item.ToString();
            //    }
            //    sum += Convert.ToInt32(character);
            //}
            //if (sum == n)
            //{
            //    return 1;
            //}
            //else
            //{
            //    return 0;
            //}
        }
    }
}
