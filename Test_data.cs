using System;


namespace Assignment1
{
    internal class Test_data
    {
        static void Main(string[] args)
        {
           int x, y, z;

            Console.Write("Enter first number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number: ");
            z = Convert.ToInt32(Console.ReadLine());

            // Calculate (x + y) * z
            int result1 = (x + y) * z;

            // Calculate x * y + y * z
            int result2 = x * y + y * z;

            Console.WriteLine($"Result of specified numbers {x}, {y}, and {z}, (x+y)*z is {result1} and x*y + y*z is {result2}");
            Console.Read();
        }
    }
 
}
