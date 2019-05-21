using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivalent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isTrivalent(new int[] { 22, 19, 10, 10, 19, 22, 22, 10 }));
            Console.WriteLine(isTrivalent(new int[] { 1, 2, 2, 2, 2, 2, 2 }));
            Console.WriteLine(isTrivalent(new int[] { -1, 0, 1, 0, 0, 0 }));
            Console.WriteLine(isTrivalent(new int[] { }));
            Console.WriteLine(isTrivalent(new int[] { 2147483647, -1, -1, -2147483648 }));

            Console.ReadLine();
        }

        public static int isTrivalent(int[] a)
        {
            int count = 0;
            int secondNum = 0;
            int thirdNum = 0;
            if (a.Length == 0)
            {
                return 0;
            }

            int firstNum = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                if (firstNum != a[i])
                {
                    secondNum = a[i];
                    break;
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (firstNum != a[i] && secondNum != a[i])
                {
                    thirdNum = a[i];
                    break;
                }
                else
                {
                    count++;
                }
            }
            if (count == a.Length)
            {
                return 0;
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (firstNum == a[i] || secondNum == a[i] || thirdNum == a[i])
                {
                    continue;
                }
                else
                {
                    return 0;
                }
            }
            return 1;
        }
    }
}
