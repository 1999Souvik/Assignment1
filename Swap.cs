using System;


namespace Assignment1
{
    internal class Program
    {
        static void SwapByValue(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }


        static void Main(string[] args)
        {
            int FNum, SNum;

            Console.Write("Input the First Number: ");
            FNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Second Number: ");
            SNum = Convert.ToInt32(Console.ReadLine());

            SwapByValue(ref FNum,ref  SNum);

            Console.WriteLine($" First Number: {FNum}");
            Console.WriteLine($" Second Number: {SNum}");
            Console.Read();
        }
    }
}
