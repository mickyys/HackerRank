using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Staircase
    {
        static void staircase(int n)
        {          
            for (int i = 0; i < n; i++)
            {
                string texto = string.Empty;
                int espacio = n - i - 1;             
                texto = texto.PadLeft(espacio, ' ').PadRight(n, '#');                 
              
                Console.WriteLine("N° {0} : {1}", i + 1, texto);
            }
            // Complete this function
        }

        public static void inicio(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            staircase(n);
            Console.ReadLine();
        }
    }
}
