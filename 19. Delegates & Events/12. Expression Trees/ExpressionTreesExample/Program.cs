using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ExpressionTreesExample
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main()
        {
            //Create object of Student class
            Student s = new Student() { StudentID = 101, StudentName = "Scott", Age = 15 };
            
            //Create expression tree with Func
            Expression<Func<Student, bool>> expression = st => st.Age > 12 && st.Age < 20;

            //Compile expression using Compile method to invoke it as Delegate
            Func<Student, bool> myDelegate = expression.Compile();

            //Execute the method
            bool result = myDelegate.Invoke(s);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}


