using System;

namespace Assignment1
{
    internal class Multiply
    {
         static void Main(String[] args)

        {
            double FNum, SNum, TNum, Result;

            Console.Write("Input the first number to multiply: ");
            FNum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            SNum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            TNum= Convert.ToDouble(Console.ReadLine());

            
            Result = FNum * SNum * TNum;

            Console.WriteLine($"{FNum} * {SNum} * {TNum} = {Result}");
            Console.Read();
        }
    }
}
