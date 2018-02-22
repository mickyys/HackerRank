using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Mini_MaxSum
    {
        static void miniMaxSum(int[] arr)
        {
            arr = arr.OrderBy(i => i).ToArray();
            long min = 0;
            long max = 0;

            for(int i = 0; i < arr.Length - 1; i++)
            {
                min = min + arr[i];
            }

            for (int i = 1; i < arr.Length; i++)
            {
                max = max + arr[i];
            }

            Console.WriteLine("{0} {1}", min, max);

            // Complete this function
        }

        public static void inicio(String[] args)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            miniMaxSum(arr);
            Console.ReadLine();
        }
    }
}
