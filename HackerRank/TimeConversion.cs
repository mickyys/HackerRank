﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class TimeConversion
    {
        static string timeConversion(string s)
        {
            DateTime dt = DateTime.Parse(s);
            return dt.ToString("HH:mm:ss");
            // Complete this function
        }

        public static void Inicio()
        {
            string s = Console.ReadLine();
            string result = timeConversion(s);
            Console.WriteLine(result);
            Console.ReadLine();
              
        }
    }
}
