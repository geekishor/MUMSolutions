using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isSquare(25));
            //Console.WriteLine(isSquare(5));
            //Console.WriteLine(isSquare(5));
            //Console.WriteLine(isSquare(5));
            //Console.WriteLine(isSquare(5));
            //Console.WriteLine(isSquare(5));
            Console.WriteLine(isSquare(5));
            Console.ReadLine();
        }
        public static double isSquare(int number)
        {
            double t;
            double squareRoot = number / 2;

            do
            {
                t = squareRoot;
                squareRoot = (t + (number / t)) / 2;
            } while ((t - squareRoot) != 0);

            return squareRoot;

        }
    }
}
