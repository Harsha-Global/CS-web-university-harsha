using System;

namespace CopyAndClone
{
    //model class
    class Employee
    {
        public string EmployeeName { get; set; }
        public string Role { get; set; }
    }
    class Program
    {
        static void Main()
        {
            Employee[] employees = new Employee[]
            {
                new Employee() { EmployeeName = "Joseph", Role = "Developer" },
                new Employee() { EmployeeName = "Jack", Role = "Designer" },
                new Employee() { EmployeeName = "Alexa", Role = "Analyst" }
            };

            //new array
            Employee[] highlyPaidEmployees = new Employee[5];
            //CopyTo
            employees.CopyTo(highlyPaidEmployees, 2);
            employees[0].Role = "Changed";

            //print destination array
            Console.WriteLine("CopyTo:");
            foreach (Employee emp in highlyPaidEmployees)
            {
                if (!(emp is null))
                {
                    Console.WriteLine(emp.EmployeeName + ", " + emp.Role);
                }
                else
                {
                    Console.WriteLine("null object");
                }
            }

            //Clone
            Employee[] highlyPaidEmployees2 = (Employee[])employees.Clone();  //createss a  new array & copies from source array to that new array
            Console.WriteLine("\nClone:");
            foreach (Employee emp in highlyPaidEmployees2)
            {
                if (!(emp is null))
                {
                    Console.WriteLine(emp.EmployeeName + ", " + emp.Role);
                }
                else
                {
                    Console.WriteLine("null object");
                }
            }

            Console.ReadKey();
        }
    }
}
