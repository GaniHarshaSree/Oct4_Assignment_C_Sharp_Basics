using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oct4_Assignment
{
    internal class studentMarks_6
    {
        public static void Main()
        {
            Console.WriteLine("Enter First Subject Marks:");
            int mark1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Subject Marks :");
            int mark2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Subject Marks :");
            int mark3 = Convert.ToInt32(Console.ReadLine());
            grade(mark1, mark2, mark3);
        }

        public static void grade(int m1, int m2, int m3)
        {
            int total = m1 + m2 + m3;
            int avg = total / 3;
            Console.WriteLine($"The Total marks of Three subjects: {total}");
            Console.WriteLine();
            if (avg < 35)
            {
                Console.WriteLine(" Grade : fail");
            }
            else if (avg > 35 && avg < 45)
            {
                Console.WriteLine(" Grade : Third");
            }
            else if (avg > 45 && avg < 60)
            {
                Console.WriteLine(" Grade : Second");
            }
            else
            {
                Console.WriteLine(" Grade : First");
            }

            Console.Read();
        }
    }
}
