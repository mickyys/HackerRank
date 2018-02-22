using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class BirthdayCakeCandles
    {
        static int birthdayCakeCandles(int n, int[] ar)
        {
            int numeroMaximo = ar.Max();
            int cantidad = ar.Count(i => i == numeroMaximo);
            return cantidad;
            // Complete this function
        }

        public static void inicio()
        {
            int n = 4; // Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = "3 2 1 3".Split(' '); // Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = birthdayCakeCandles(n, ar);
            Console.WriteLine(result);
        }
    }
}
