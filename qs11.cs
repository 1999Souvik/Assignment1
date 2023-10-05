using System;


namespace Assignment1
{
    internal class qs11
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of days: ");
            int days = Convert.ToInt32(Console.ReadLine());

            int years, weeks, remainingDays;

            // Calculate years
            years = days / 365;
            remainingDays = days % 365;

            // Calculate weeks
            weeks = remainingDays / 7;
            remainingDays = remainingDays % 7;

            Console.WriteLine($"{days} days is approximately {years} years, {weeks} weeks, and {remainingDays} days.");
            Console.Read();
        }
    }

}
