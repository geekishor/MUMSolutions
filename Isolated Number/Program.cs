using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isolated_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isIsolated(2));
            Console.WriteLine(isIsolated(3));
            Console.WriteLine(isIsolated(8));
            Console.WriteLine(isIsolated(9));
            Console.WriteLine(isIsolated(14));
            Console.WriteLine(isIsolated(24));
            Console.WriteLine(isIsolated(28));
            Console.WriteLine(isIsolated(34));
            Console.WriteLine(isIsolated(58));
            Console.WriteLine(isIsolated(63));

            Console.WriteLine(isIsolated(162));


            Console.ReadLine();
        }
        public static int isIsolated(int n)
        {
            List<long> squareList = new List<long>();
            List<long> cubeList = new List<long>();

            if (n < 1 || n > 2097151)
            {
                return -1;
            }
            else
            {
                long square = n * n;
                long cube = n * n * n;

                while (square > 0)
                {
                    squareList.Add(square % 10);
                    square = square / 10;
                }

                while (cube > 0)
                {
                    cubeList.Add(cube % 10);
                    cube = cube / 10;
                }

                var squareArr = squareList.ToArray();
                var cubeArr = cubeList.ToArray();

                for(int i = 0; i < squareArr.Length; i++)
                {
                    for(int j = 0; j < cubeArr.Length; j++)
                    {
                        if(squareArr[i] != cubeArr[j])
                        {
                            continue;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                return 1;
            }
        }
    }
}
