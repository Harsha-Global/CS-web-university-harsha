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
        public double Salary { get; set; }
    }

    class Program
    {
        static void Main()
        {
            //collection of objects
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { EmpID = 101, EmpName = "Henry", Job = "Designer", Salary = 7232 },
                new Employee() { EmpID = 102, EmpName = "Jack", Job = "Developer", Salary = 4500 },
                new Employee() { EmpID = 103, EmpName = "Gabriel", Job = "Analyst", Salary = 1293 },
                new Employee() { EmpID = 104, EmpName = "William", Job = "Manager", Salary = 2873 },
                new Employee() { EmpID = 105, EmpName = "Alexa", Job = "Manager", Salary = 6232 },
                new Employee() { EmpID = 102, EmpName = "Jessica", Job = "Manager", Salary = 4545 }
            };

            //Single
            Employee resultEmployee1 = employees.Single(emp => emp.EmpID == 102);
            Console.WriteLine(resultEmployee1.EmpID + ", " + resultEmployee1.EmpName + ", " + resultEmployee1.Job);

            //SingleOrDefault
            Employee resultEmployee2 = employees.SingleOrDefault(emp => emp.Job == "Clerk");
            if (resultEmployee2 != null)
            {
                Console.WriteLine(resultEmployee2.EmpID + ", " + resultEmployee2.EmpName + ", " + resultEmployee2.Job);
            }
            else
            {
                Console.WriteLine("No matching employee");
            }
            

            Console.ReadKey();
        }
    }
}
