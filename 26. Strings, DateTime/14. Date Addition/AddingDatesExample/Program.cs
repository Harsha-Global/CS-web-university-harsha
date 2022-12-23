using System;

namespace AddingDatesExample
{
    class Program
    {
        static void Main()
        {
            DateTime dt = DateTime.Parse("2022-01-01 12:00 am");
            DateTime dt_after_10_days = dt.AddDays(10);
            Console.WriteLine("After 10 days: " + dt_after_10_days);
            DateTime dt_before_10_days = dt.AddDays(-10);
            Console.WriteLine("Before 10 days: " + dt_before_10_days);

            DateTime dt_after_20_months_and_5_days = dt.AddMonths(20).AddDays(5);
            Console.WriteLine("After 20 months and 5 days: " + dt_after_20_months_and_5_days);
            Console.ReadKey();
        }
    }
}
