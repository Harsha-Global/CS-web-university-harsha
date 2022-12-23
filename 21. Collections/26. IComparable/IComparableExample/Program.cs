using System;
using System.Collections.Generic;

namespace IComparableExample
{
    //moodel class
    class Employee: IComparable
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }

        //Sort by EmpID (int)
        //public int CompareTo(object other)
        //{
        //    Employee otherEmp = (Employee)other;
        //    Console.WriteLine(this.EmpID + ", " + otherEmp.EmpID);
        //    return this.EmpID - otherEmp.EmpID;  //returns 0, -1 or 1
        //}

        //Sort by EmpName (string)
        public int CompareTo(object other)
        {
            Employee otherEmp = (Employee)other;
            Console.WriteLine(this.EmpName + ", " + otherEmp.EmpName);
            return this.EmpName.CompareTo(otherEmp.EmpName);  //returns 0, -1 or 1
        }
    }
    class Program
    {
        static void Main()
        {
            //list of employees
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { EmpID = 104, EmpName = "Mary", Job = "Designer" },
                new Employee() { EmpID = 102, EmpName = "Alexa", Job = "Manager" },
                new Employee() { EmpID = 101, EmpName = "Steven", Job = "Consultant" },
                new Employee() { EmpID = 103, EmpName = "Jade", Job = "Analyst" }
            };
            employees.Sort();
            foreach (Employee item in employees)
            {
                Console.WriteLine(item.EmpID + ", " + item.EmpName + ", " + item.Job);
            }

            Console.ReadKey();
        }
    }
}
