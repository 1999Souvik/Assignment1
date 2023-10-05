using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Operator_demo
    {
        static void Main(string[] args)
        {
            int x , y;

            Console.Write("Input the first number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number: ");
            y = Convert.ToInt32(Console.ReadLine());

            int sum = x + y ;
            int difference = x - y;
            int product = x * y;
            float quotient = x / y ;
            float remainder = x % y;

            Console.WriteLine($"{x} + {y} = {sum}");
            Console.WriteLine($"{x} - {y} = {difference}");
            Console.WriteLine($"{x} x {y} = {product}");
            Console.WriteLine($"{x}  /  {y} = {quotient}");
            Console.WriteLine($"{x}  mod  {y} = {remainder}");
            Console.Read();
        }
    }
}
