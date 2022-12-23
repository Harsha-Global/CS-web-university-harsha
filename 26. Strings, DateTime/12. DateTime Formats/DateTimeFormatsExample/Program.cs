using System;

namespace DateTimeFormatsExample
{
    class Program
    {
        static void Main()
        {
            //DateTime dt = DateTime.Parse("2020-12-31 11:59:59.999 pm");
            //DateTime dt = DateTime.ParseExact("31/12/2020 23:59:59", "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None); //dd/MM/yyyy HH:mm:ss

            DateTime dt = new DateTime(2020, 12, 31, 23, 59, 59, 999);
            string str1 = dt.ToString(); //MM/dd/yyyy hh:mm:ss tt
            string str2 = dt.ToShortDateString(); //MM/dd/yyyy
            string str3 = dt.ToLongDateString(); //dd MMMM yyyy
            string str4 = dt.ToShortTimeString(); //hh:mm tt
            string str5 = dt.ToLongTimeString(); //hh:mm:ss tt
            string str6 = dt.ToString("dd-MM-yyyy HH:mm:ss");

            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine(str4);
            Console.WriteLine(str5);
            Console.WriteLine(str6);
            Console.WriteLine(DateTime.DaysInMonth(2022, 7));
            Console.ReadKey();
        }
    }
}
