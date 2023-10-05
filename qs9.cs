using System;


namespace Assignment1
{
    internal class qs9
    {
        static void Main()
        {
            Console.Write("Enter the first integer: ");
            int FNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int SNum = Convert.ToInt32(Console.ReadLine());

            int sum = FNum + SNum;

            if (FNum == SNum)
            {
                int triple_Of_Sum = 3 * sum;
                Console.WriteLine($"The two numbers are equal so triple of their sum is {triple_Of_Sum}");
            }
            else
            {
                Console.WriteLine($"The sum of the two numbers is {sum}");
            }
            Console.Read();
        }  
    }
}
