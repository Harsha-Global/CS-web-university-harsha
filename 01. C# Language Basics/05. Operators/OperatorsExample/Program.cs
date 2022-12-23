class Program
{
    static void Main()
    {
        //Arithmetical Operators
        decimal a = 10M;
        decimal b = 3M;
        decimal c = a + b; //Output: 13
        decimal d = a - b; //Output: 7
        decimal e = a * b; //Output: 30
        decimal f = a / b; //Output: 3.3333333
        decimal g = a % b; //Output: 1
        System.Console.WriteLine(c);
        System.Console.WriteLine(d);
        System.Console.WriteLine(e);
        System.Console.WriteLine(f);
        System.Console.WriteLine(g);

        //Assignment Operators
        a += 20M;
        System.Console.WriteLine(a); //Output: 30
        a -= 20M;
        System.Console.WriteLine(a); //Output: 10
        a *= 3M;
        System.Console.WriteLine(a); //Output: 30
        a /= 3M;
        System.Console.WriteLine(a); //Output: 10
        a %= 3M;
        System.Console.WriteLine(a); //Output: 1

        //Increment / Decrement Operators
        a = 10M;
        System.Console.WriteLine();
        System.Console.WriteLine(++a); //Output: 11
        System.Console.WriteLine(a++); //Output: 11
        System.Console.WriteLine(a); //Output: 12
        System.Console.WriteLine(--a); //Output: 11
        System.Console.WriteLine(a--); //Output: 11
        System.Console.WriteLine(a); //Output: 10

        //Comparison Operators
        System.Console.WriteLine();
        bool b1 = a == 10;
        System.Console.WriteLine(b1); //Output: true
        bool b2 = a != 10;
        System.Console.WriteLine(b2); //Output: false
        bool b3 = a < 10;
        System.Console.WriteLine(b3); //Output: false
        bool b4 = a > 10;
        System.Console.WriteLine(b4); //Output: false
        bool b5 = a <= 10;
        System.Console.WriteLine(b5); //Output: true
        bool b6 = a >= 10;
        System.Console.WriteLine(b6); //Output: true


        //Logical Operators
        System.Console.WriteLine();
        bool b7 = a == 10 & b == 10;
        System.Console.WriteLine(b7); //Output: false
        bool b8 = a == 10 && b == 10;
        System.Console.WriteLine(b8); //Output: false
        bool b9 = a == 10 | b == 10;
        System.Console.WriteLine(b9); //Output: true
        bool b10 = a == 10 || b == 10;
        System.Console.WriteLine(b10); //Output: true
        bool b11 = !(a == 10);
        System.Console.WriteLine(b11); //Output: false
        bool b12 = a == 10 ^ b == 10;
        System.Console.WriteLine(b12); //Output: true

        //concatenation operator
        string name = "Scott";
        int age = 20;
        string message = "Hey " + name + ", your age is " + age + ".";
        System.Console.WriteLine(message);

        //ternary operator
        string title = (age < 13) ? "Child" : (age >= 13 && age <= 19) ? "Teenager" : "Adult";
        System.Console.WriteLine(title);

        //operator precedence
        double z = 10 + 4 * 30 / 10;
        System.Console.WriteLine(z); //Output: 22

        System.Console.ReadKey();
    }
}
