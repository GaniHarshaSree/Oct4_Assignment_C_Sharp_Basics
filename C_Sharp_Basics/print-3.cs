using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oct4_Assignment
{
    internal class print3
    {
        public static void Main(String[] args)
        {
            Console.Write("Input the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);

            Console.Read();
        }
    }
}
