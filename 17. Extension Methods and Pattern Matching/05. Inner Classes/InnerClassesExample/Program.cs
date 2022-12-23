using ClassLibrary1;
using System;

namespace InnerClassesExample
{
    class Program
    {
        static void Main()
        {
            //create an object of inner class
            ClassLibrary1.MarksCalculation.CalculationHelper ch = new ClassLibrary1.MarksCalculation.CalculationHelper();

            //call the inner class's method
            Console.WriteLine(ch.Multiply(10, 5));

            //call outer class's method
            ClassLibrary1.MarksCalculation mc = new ClassLibrary1.MarksCalculation();
            Student s = new Student() { SecuredMarks = 35, MaxMarks = 50 };

            mc.CalculatePercentage(s);
            Console.WriteLine(s.Percentage);

            Console.ReadKey();
        }
    }
}
