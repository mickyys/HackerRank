using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class PlusMinus
    {
        static void plusMinus(int[] arr)
        {
            Console.WriteLine("{0:N6}", Decimal.Divide(arr.Where(i => i > 0).Count(),arr.Length));
            Console.WriteLine("{0:N6}", Decimal.Divide(arr.Where(i => i < 0).Count(),arr.Length));
            Console.WriteLine("{0:N6}", Decimal.Divide(arr.Where(i => i == 0).Count(), arr.Length));
            // Complete this function
        }

        public static void inicio(String[] args)
        {
            //int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            plusMinus(arr);
            Console.ReadLine();
        }
    }
}
