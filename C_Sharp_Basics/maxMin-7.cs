﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oct4_Assignment
{
    internal class maxMin_7
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int maxNum;

            Console.Write("Enter first number - ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number - ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                maxNum = num1;
            }
            else
            {
                maxNum = num2;
            }
            
            Console.WriteLine("Maximum number is: " + maxNum);
            
            Console.Read();
        }
    }
}
