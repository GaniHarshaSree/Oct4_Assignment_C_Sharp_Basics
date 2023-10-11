using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oct4_Assignment
{
    internal class swap1
    {
        static void Main(string[] args)
        {
            int number1, number2, temp;
            Console.Write("\nInput the First Number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("\nInput the Second Number : ");
            number2 = int.Parse(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.Write("After Swapping : ");
            Console.Write("First Number : " + number1);
            Console.Write("Second Number : " + number2);
            Console.Read();
        }
    }
}
