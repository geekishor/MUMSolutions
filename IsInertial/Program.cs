using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsInertial
{
    class Program
    {
        internal static List<int> odd;
        internal static List<int> even;
        static void Main(string[] args)
        {
            Console.WriteLine(isInertial(new int[] { 1 }));
            Console.WriteLine(isInertial(new int[] { 2 }));
            Console.WriteLine(isInertial(new int[] { 1, 2, 3, 4 }));
            Console.WriteLine(isInertial(new int[] { 1, 1, 1, 1, 1, 1, 2 }));
            Console.WriteLine(isInertial(new int[] { 2, 12, 4, 6, 8, 11 }));
            Console.WriteLine(isInertial(new int[] { 2, 12, 12, 4, 6, 8, 11 }));
            Console.WriteLine(isInertial(new int[] { -2, -4, -6, -8, -11 }));
            Console.WriteLine(isInertial(new int[] { 2, 3, 5, 7 }));
            Console.WriteLine(isInertial(new int[] { 2, 4, 6, 8, 10 }));

            Console.ReadLine();
        }
        public static int isInertial(int[] arr)
        {
            try
            {
                bool containsOdd = containsOddValue(arr);
                int checkInertialCount = 0;
                int[] oddArr = { };
                int[] evenArr = { };
                if (containsOdd)
                {
                    bool isMaxEven = isMaximumEven(arr);
                    if (isMaxEven)
                    {
                        splitOddEvenArray(arr);

                        oddArr = odd.ToArray();
                        int max = arr.Max();
                        var index = even.FindIndex(i => i == max);
                        even.RemoveAt(index);

                        evenArr = even.ToArray();

                        int minOdd = oddArr[0];
                        for (int i = 1; i < oddArr.Length; i++)
                        {
                            if (minOdd > oddArr[i])
                                minOdd = oddArr[i];
                        }
                        if (evenArr.Length == 0)
                        {
                            return 1;
                        }
                        int maxEven = evenArr[0];

                        for (int j = 0; j < evenArr.Length; j++)
                        {
                            if (maxEven > evenArr[j])
                                maxEven = evenArr[j];
                        }

                        if (minOdd > maxEven)
                        {
                            for (int i = 0; i < oddArr.Length; i++)
                            {
                                if (oddArr[i] < max)
                                {
                                    checkInertialCount++;
                                }
                            }
                            //do someting
                        }

                        if (checkInertialCount == oddArr.Length)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                return 0;

            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public static bool containsOddValue(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool isMaximumEven(int[] arr)
        {
            bool isMaxEven = false;
            for (int i = 0; i < arr.Length; i++)
            {
                int max = arr.Max();
                if (max % 2 == 0)
                {
                    isMaxEven = true;
                    break;
                }
            }
            if (isMaxEven)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void splitOddEvenArray(int[] arr)
        {
            even = new List<int>();
            odd = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even.Add(arr[i]);
                }
                else
                {
                    odd.Add(arr[i]);
                }
            }
        }
    }
}
