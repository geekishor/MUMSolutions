using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fill_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array arr = fill(new int[] { 1, 2, 3, 5, 9, 12, -2, -1 }, 3, 10);
            Array arr = fill(new int[] { 4, 2, -3, 12 }, 1, 5);
            //  Array arr = fill(new int[] { 2, 6, 9, 0, -3 }, 0, 4);


            StringBuilder builder = new StringBuilder();
            foreach (int i in arr)
            {
                builder.Append(i).Append(",");
            }
            string Value = builder.ToString();
            Console.WriteLine("{" + Value.TrimEnd(',') + "}");
            Console.ReadLine();
        }
        public static Array fill(int[] arr, int k, int n)
        {
            if (k <= 0)
            {
                return null;
            }
            List<int> list = new List<int>();
            do
            {
                for (int i = 0; i < k; i++)
                {
                    list.Add(arr[i]);
                    if (list.Count == n)
                    {
                        return list.ToArray();
                    }
                }
            } while (true);
        }
    }
}
