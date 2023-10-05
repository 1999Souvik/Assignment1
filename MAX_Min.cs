using System;
using System.Collections.Generic;
using System.Linq;


namespace Assignment1
{
    internal class MAX_Min
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double FNum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double SNum= Convert.ToDouble(Console.ReadLine());

            double maximum, minimum;

            
            if (FNum > SNum)
            {
                maximum = FNum;
            }
            else
            {
                maximum = SNum;
            }

            
            if (FNum < SNum)
            {
                minimum = FNum;
            }
            else
            {
                minimum = SNum;
            }

            Console.WriteLine($"Maximum: {maximum}");
            Console.WriteLine($"Minimum: {minimum}");
            Console.Read();
        }
    }
}
