using System;
using System.Collections.Generic;

namespace Company
{
    /// <summary>
    /// Represents an employee of the organization
    /// </summary>
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public Department dept { get; set; }
    }
}
