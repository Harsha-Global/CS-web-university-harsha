using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Student
    {
        //private field
        private string _studentName;

        //public method
        public int GetStudentNameLength() => _studentName.Length;

        //public constructors
        public Student() => _studentName = "Harsha";

        //public properties
        public string StudentName
        {
            set => _studentName = value;
            get => _studentName;
        }
    }
}


