using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class qs5

    {
        static void Main(string[] args)
        {
            Console.Write("Enter a digit: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Using Console.Write and string formatting
            Console.Write("{0} {0} {0} {0}\n", number);
            Console.Write("{0}{0}{0}{0}\n", number);

            // Using string interpolation
            Console.WriteLine($"{number} {number} {number} {number}");
            Console.WriteLine($"{number}{number}{number}{number}");
            Console.Read();
        }
    }
}

