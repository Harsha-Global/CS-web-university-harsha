class Student
{
    public int RollNumber { get; set; }
    public List<int> Marks { get; set; }
}

class Teacher
{
    public static int MinPassMarksStatic { get; set; } = 35;
    public const int MinPassMarksConstant = 35;
    public int MinPassMarksInstanceProp { get; set; } = 35;

    public void GetMarksOfPassedSubjects(int minimumPassMarksParameter)
    {
        Student student = new Student()
        {
            RollNumber = 1,
            Marks = new List<int>() { 34, 10, 50, 78, 40 }
        };

        int minimimPassMarksLocalVariable = 35;
        //Get marks of passed subjects. Assuming minimum pass marks: 35
        IEnumerable<int> passedSubjectsMarks = student.Marks.Where(static (int n) => {
            if (n >= MinPassMarksStatic)
                return true;
            else
                return false;
        });

        foreach (int item in passedSubjectsMarks)
        {
            Console.WriteLine(item);
        }
    }
}

class Program
{
    static void Main()
    {
        Teacher teacher = new Teacher();
        teacher.GetMarksOfPassedSubjects(35);
        Console.ReadKey();
    }
}