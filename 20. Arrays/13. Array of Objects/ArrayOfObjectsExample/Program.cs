using System;
using ClassLibrary1;

namespace ArrayOfObjectsExample
{
    class Program
    {
        static void Main()
        {
            //create array of objects
            Employee[ ] employees = new Employee[ ]
            {
                new Employee() { EmpID = 101, EmpName = "Scott" },
                new Employee() { EmpID = 102, EmpName = "Smith" },
                new Employee() { EmpID = 103, EmpName = "John" }
            };

            //foreach loop for array of objects
            foreach(Employee item in employees)
            {
                if (item.EmpID >= 102)
                {
                    Console.WriteLine(item.EmpID + ", " + item.EmpName);
                }
            }

            Console.ReadKey();
        }
    }
}
