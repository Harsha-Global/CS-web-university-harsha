class Program
{
    static void Main()
    {
        //create structure instance
        Structure1 structure1;
        structure1.x = 10;
        structure1.y = 20;

        //create object based on class
        Class1 class1;
        class1 = new Class1();
        class1.x = 10;
        class1.y = 20;

        //create structure instance 2
        Structure1 structure2;

        //create reference variable of Class1
        Class1 class2;

        //copy data from structure1 to structure2
        structure2 = structure1;

        //copy reference from class1 to class2
        class2 = class1;

        //modify data of structure2
        structure2.x = 100;
        structure2.y = 200;

        //modify data of object through reference variable 2
        class2.x = 100;
        class2.y = 200;

        //print the value of structure1 and structure2
        System.Console.WriteLine(structure1.x); //Output: 10
        System.Console.WriteLine(structure1.y); //Output: 20
        System.Console.WriteLine(structure2.x); //Output: 100
        System.Console.WriteLine(structure2.y); //Output: 200

        //print the value of object using both reference variables
        System.Console.WriteLine(class1.x); //Output: 100
        System.Console.WriteLine(class1.y); //Output: 200
        System.Console.WriteLine(class2.x); //Output: 100
        System.Console.WriteLine(class2.y); //Output: 200

        System.Console.ReadKey();
    }
}