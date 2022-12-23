Something something = new Something();
Console.WriteLine(something.student);
Console.WriteLine(something.techer);
Console.ReadKey();

class Something
{
    public College.Student student = new College.Student();
    public College.Teacher techer = new College.Teacher();
}

