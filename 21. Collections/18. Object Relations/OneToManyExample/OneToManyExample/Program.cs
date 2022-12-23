using System;
using System.Collections.Generic;
using College;

namespace OneToManyExample
{
    class Program
    {
        static void Main()
        {
            //Create object of Student class
            Student student = new Student();
            student.RollNo = 1;
            student.StudentName = "Allen";
            student.Email = "allen@gmail.com";
            student.examinations = new List<Examination>();
            student.examinations.Add(new Examination() { ExaminationName = "Module Test 1", Month = 5, Year = 2021, MaxMarks = 100, SecuredMarks = 87 });
            student.examinations.Add(new Examination() { ExaminationName = "Module Test 2", Month = 7, Year = 2022, MaxMarks = 100, SecuredMarks = 70 });
            student.examinations.Add(new Examination() { ExaminationName = "Final Test", Month = 3, Year = 2024, MaxMarks = 100, SecuredMarks = 91 });

            //print
            Console.WriteLine("Roll No: " + student.RollNo);
            Console.WriteLine("Student Name: " + student.StudentName);
            Console.WriteLine("Email: " + student.Email);
            Console.WriteLine("EXAMINATIONS:");
            foreach (Examination exam in student.examinations)
            {
                Console.WriteLine(exam.ExaminationName + ", " + exam.Year + "-" + exam.Month + ", " + exam.SecuredMarks + "/" + exam.MaxMarks);
            }

            Console.ReadKey();
        }
    }
}
