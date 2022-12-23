using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExample
{
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }
        public string City { get; set; }
    }

    class Program
    {
        static void Main()
        {
            //collection of objects
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { EmpID = 101, EmpName = "Henry", Job = "Designer", City = "Boston" },
                new Employee() { EmpID = 102, EmpName = "Jack", Job = "Developer", City = "New York" },
                new Employee() { EmpID = 103, EmpName = "Gabriel", Job = "Analyst", City = "Tokyo" },
                new Employee() { EmpID = 104, EmpName = "William", Job = "Manager", City = "Tokyo" },
                new Employee() { EmpID = 105, EmpName = "Alexa", Job = "Manager", City = "New York" }
            };

            //var result = employees.Where(emp => emp.Job == "Manager");
            // IEnumerable<Employee> result = employees.Where(emp => emp.City == "New York");
            IEnumerable<Employee> result = employees.Where(emp => emp.City == "London");
            foreach (Employee item in result)
            {
                Console.WriteLine(item.EmpID + ", " + item.EmpName + ", " + item.Job + ", " + item.City);
            }

            Console.ReadKey();
        }
    }
}
