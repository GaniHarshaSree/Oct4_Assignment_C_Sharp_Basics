using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oct4_Assignment
{
    internal class differentRows_5
    {
        public static void Main(String[] args)
        {
            int num;
            Console.WriteLine("Enter a digit: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.WriteLine();
            Console.Write(num);
            Console.Write(num);
            Console.Write(num);
            Console.WriteLine(num);
            Console.WriteLine();
            Console.WriteLine("{0} {0} {0} {0}", num);
            Console.WriteLine("{0}{0}{0}{0}", num);

            Console.Read();
        }
    }
}
