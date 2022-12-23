﻿class Student
{
    //method
    public void DisplayMarks(int marks1, int marks2, int marks3)
    {
        double avgMarks = getAverageMarks();
        System.Console.WriteLine("Marks 1: " + marks1);
        System.Console.WriteLine("Marks 2: " + marks2);
        System.Console.WriteLine("Marks 3: " + marks3);
        System.Console.WriteLine("Average marks: " + avgMarks);

        //create local function
        double getAverageMarks()
        {
            //create local variable of local function
            double avg;
            avg = (double)(marks1 + marks2 + marks3) / 3;
            return avg;
        }
    }
}

class Program
{
    static void Main()
    {
        //create object for Student class
        Student s = new Student();

        //call DisplayMarks method
        s.DisplayMarks(80, 45, 71);

        System.Console.ReadKey();
    }
}