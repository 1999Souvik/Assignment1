using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Grading
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first mark: ");
            int m1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second mark: ");
            int m2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third mark: ");
            int m3 = Convert.ToInt32(Console.ReadLine());

            int avgMark = (m1 + m2 + m3) / 3;
            

            string grade;

            if (avgMark >= 60)
            {
                grade = "First";
            }
            else if (avgMark >= 45)
            {
                grade = "Second";
            }
            else if (avgMark >= 35)
            {
                grade = "Third";
            }
            else
            {
                grade = "Fail";
            }

            Console.WriteLine($"Average Mark: {avgMark}");
            Console.WriteLine($"Grade: {grade}");
            Console.Read();
        }

    }
}
