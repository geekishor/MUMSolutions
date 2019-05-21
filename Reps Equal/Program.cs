using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reps_Equal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(respEqual(new int[] { 3, 2, 0,5, 3 }, 32053));
            Console.WriteLine(respEqual(new int[] { 3, 2, 0, 5 }, 32053)); 
            Console.WriteLine(respEqual(new int[] { 3, 2, 0, 5, 3, 4 }, 32053));
            Console.WriteLine(respEqual(new int[] { 3, 2, 0, 5, 3, 0 }, 32053));
            Console.WriteLine(respEqual(new int[] { 9, 3, 1, 1, 2 }, 32053));
            Console.WriteLine(respEqual(new int[] { 0, 0, 0, 0, 3, 2, 0, 5, 3 }, 32053));
            Console.ReadLine();
        }

        public static int respEqual(int[] arr, int n)
        {
            string num = n.ToString();
            int count = 0;
            bool checkZero = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if (checkZero)
                {
                    if (arr[0] == 0)
                    {
                        checkZero = true;
                        var arrList = arr.ToList();
                        arrList.RemoveAt(0);
                        arr = arrList.ToArray();
                        continue;
                    }
                    else
                    {
                        checkZero = false;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (num.Length == arr.Length)
                {
                    if (arr[i].ToString() == num[i].ToString())
                    {
                        count++;
                    }
                }
            }
            if (count == arr.Length)
            {
                return 1;
            }
            return 0;
        }
    }
}
