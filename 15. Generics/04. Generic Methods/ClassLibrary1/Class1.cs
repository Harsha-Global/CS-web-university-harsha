public class Employee
{
    public int Salary;
}

public class Student
{
    public int Marks;
}

//a class with generic method
public class Sample
{
    //generic method
    public void PrintData<T>(T obj) where T : class
    {
        if (obj.GetType() == typeof(Student))
        {
            Student temp = obj as Student;
            System.Console.WriteLine(temp.Marks);
        }
        else if (obj.GetType() == typeof(Employee))
        {
            Employee temp = obj as Employee;
            System.Console.WriteLine(temp.Salary);
        }
    }
}