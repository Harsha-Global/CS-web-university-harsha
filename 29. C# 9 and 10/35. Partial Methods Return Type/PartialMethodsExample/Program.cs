using PartialMethodsExample;

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.StudentID = 1;
        Console.WriteLine(s.StudentID);
        Console.WriteLine(s.GetStudentID());
        Console.ReadKey();
    }
}