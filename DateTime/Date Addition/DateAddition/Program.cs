using System;

namespace DateAddition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Parse("2025-02-19 14:43 ");

            DateTime after_10_days = today.AddDays(10);
            Console.WriteLine("After 10 days from today is " + after_10_days.ToString());

            DateTime before_10_days = today.AddDays(-10);
            Console.WriteLine("Before 10 days from today is " + before_10_days.ToString());

            DateTime after_2months_and_23days = today.AddMonths(2).AddDays(23);
            Console.WriteLine("After 2 months and 23 days from today is " + after_2months_and_23days.ToString());

         

            Console.ReadKey();
        }
    }
}
