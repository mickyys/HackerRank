using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class DiagonalDifference
    {
        public static void inicio(string[] args)
        {
            /*
                3
                11 2 4
                4 5 6   
                10 8 -12
             */

            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }
            int result = diagonalDifference(a);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static int diagonalDifference(int[][] a)
        {
            int fdiagonal = 0;
            int sdiagonal = 0;
            for(int i=0; i<a.Length; i++)
            {
                fdiagonal = fdiagonal + a[i][i];
                sdiagonal = sdiagonal + a[i][a.Length - i -1];
            }

            Console.WriteLine("fdiagonal : " + fdiagonal);
            Console.WriteLine("sdiagonal : " + sdiagonal);

            return Math.Abs(fdiagonal - sdiagonal);
           
        }
    }
}
