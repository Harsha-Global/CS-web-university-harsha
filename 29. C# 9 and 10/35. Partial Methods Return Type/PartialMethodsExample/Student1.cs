//Student1.cs
using System;

namespace PartialMethodsExample
{
    partial class Student
    {
        private int _studentId;

        //partial method declaration
        internal partial int GetStudentID(); //by default private //can't have out parameters //return type should 'void'
    }
}
