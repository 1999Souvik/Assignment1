using System;


namespace Assignment1
{
    internal class Degree_Scale
    {
        static void Main(string[] args)
        {
            double celsius, kelvin, fahrenheit;

            Console.Write("Enter the amount of celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());

        
            kelvin = celsius + 273.15;
           
            fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"Kelvin = {kelvin:N0}");
            Console.WriteLine($"Fahrenheit = {fahrenheit:N0}");
            Console.Read();
        }
    }
}
