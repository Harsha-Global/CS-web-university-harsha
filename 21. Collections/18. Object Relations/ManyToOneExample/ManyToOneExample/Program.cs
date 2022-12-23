using System;
using System.Collections.Generic;
using Company;

namespace ManyToOneExample
{
    class Program
    {
        static void Main()
        {
            //Three employees in same department
            Employee employee1 = new Employee() { EmployeeID = 1, EmployeeName = "Scott", Email = "scott@gmail.com" };
            Employee employee2 = new Employee() { EmployeeID = 2, EmployeeName = "Allen", Email = "allen@gmail.com" };
            Employee employee3 = new Employee() { EmployeeID = 3, EmployeeName = "Smith", Email = "smith@gmail.com" };

            //create object of Department class
            Department department = new Department() { DepartmentID = 10, DepartmentName = "Accounting" };
            employee1.dept = department;
            employee2.dept = department;
            employee3.dept = department;

            //print
            Console.WriteLine("FIRST EMPLOYEE:");
            Console.Write("Employee ID: " + employee1.EmployeeID);
            Console.Write("Employee Name: " + employee1.EmployeeName);
            Console.Write("Email: " + employee1.Email);
            Console.Write("Department ID: " + employee1.dept.DepartmentID);
            Console.Write("Department Name: " + employee1.dept.DepartmentName);

            Console.WriteLine("\nSECOND EMPLOYEE:");
            Console.Write("Employee ID: " + employee2.EmployeeID);
            Console.Write("Employee Name: " + employee2.EmployeeName);
            Console.Write("Email: " + employee2.Email);
            Console.Write("Department ID: " + employee2.dept.DepartmentID);
            Console.Write("Department Name: " + employee2.dept.DepartmentName);

            Console.WriteLine("\nTHIRD EMPLOYEE:");
            Console.Write("Employee ID: " + employee3.EmployeeID);
            Console.Write("Employee Name: " + employee3.EmployeeName);
            Console.Write("Email: " + employee3.Email);
            Console.Write("Department ID: " + employee3.dept.DepartmentID);
            Console.Write("Department Name: " + employee3.dept.DepartmentName);

            Console.ReadKey();
        }
    }
}
