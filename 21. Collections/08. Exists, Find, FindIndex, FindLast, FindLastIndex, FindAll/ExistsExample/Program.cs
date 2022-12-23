using System;
using System.Collections.Generic;

namespace ExistsExample
{
    class Program
    {
        static void Main()
        {
            //collection with marks of student
            List<int> marks = new List<int>() { 40, 95, 24, 70, 16, 81 };

            //Exists: check if the student is failed
            bool b = marks.Exists(m => m < 35);
            if (b == true)
            {
                Console.WriteLine("Student is failed in one or more subjects");
            }
            else
            {
                Console.WriteLine("Student is Pass");
            }

            //Find: Get marks of first failed subject
            int firstFailedMarks = marks.Find(m => m < 35);
            Console.WriteLine("First failed marks: " + firstFailedMarks);

            //FindIndex: Get index of marks of first failed subject
            int firstFailedMarksIndex = marks.FindIndex(m => m < 35);
            Console.WriteLine("First failed marks index: " + firstFailedMarksIndex);

            //FindLast: Get marks of last failed subject
            int lastFailedMarks = marks.FindLast(m => m < 35);
            Console.WriteLine("Last failed marks: " + lastFailedMarks);

            //FindLastIndex: Get index of marks of last failed subject
            int lastFailedMarksIndex = marks.FindLastIndex(m => m < 35);
            Console.WriteLine("Last failed marks index: " + lastFailedMarksIndex);

            //FindAll: Get all failed subjects marks
            List<int> allFailedMarks = marks.FindAll(m => m < 35);
            Console.WriteLine("\nFailed marks:");
            foreach (int item in allFailedMarks)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
