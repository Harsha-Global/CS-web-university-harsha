class Program
{
    static void Main()
    {
        //create objects
        Sample sample = new Sample();
        Employee emp = new Employee() { Salary = 1000 };
        Student stu = new Student() { Marks = 80 };

        //call the generic method
        sample.PrintData<Employee>(emp);
        sample.PrintData<Student>(stu);

        System.Console.ReadKey();
    }
}