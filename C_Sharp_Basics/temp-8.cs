﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oct4_Assignment
{
    internal class temp_8
    {
        public static void Main()
        {
            Console.Write("Enter the amount of Celsius: ");
            int celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin = {0}", celsius + 273);
            Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);

            Console.Read();
        }
    }
}
