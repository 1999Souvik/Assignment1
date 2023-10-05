using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class qs10
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int FNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int SNum = Convert.ToInt32(Console.ReadLine());

            int absoluteDifference = Math.Abs(FNum- SNum);

            if (FNum > SNum)
            {
                absoluteDifference *= 2; 
            }

            Console.WriteLine("Result: " + absoluteDifference);
            Console.Read();
        }
        
    }

}
