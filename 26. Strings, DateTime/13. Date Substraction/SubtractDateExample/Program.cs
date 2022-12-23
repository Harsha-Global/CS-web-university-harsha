using System;

namespace SubtractDateExample
{
    class Employee
    {
        public string EmployeeName { get; set; }
        public DateTime DateOfJoining { get; set; }
        public double ExperienceYears { get; set; }
        public double ExperienceMonths { get; set; }
    }
    class Program
    {
        static void Main()
        {
            Employee emp = new Employee() { EmployeeName = "John", DateOfJoining = DateTime.Parse("2015-01-01") };
            //Today: 2021-10-11
            DateTime today = DateTime.Now;
            if (today.CompareTo(emp.DateOfJoining) == 1) //1, 0, -1
            {
                TimeSpan ts = today.Subtract(emp.DateOfJoining);
                emp.ExperienceYears = Math.Floor(ts.TotalDays / 365);
                emp.ExperienceMonths = Math.Floor((ts.TotalDays - (emp.ExperienceYears * 365)) / 30);
                Console.WriteLine(emp.ExperienceYears + " years and " + emp.ExperienceMonths + " months");
            }
            else
            {
                Console.WriteLine("Date of joining is greater than today's date. Subtraction is not possible");
            }

            Console.ReadKey();
        }
    }
}
