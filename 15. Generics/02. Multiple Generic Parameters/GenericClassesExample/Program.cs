class Program
{
    static void Main()
    {
        //create object of generic class
        User<int, int> user1 = new User<int, int>();
        User<bool, string> user2 = new User<bool, string>();

        //set value into generic field
        user1.RegistrationStatus = 1234;
        user2.RegistrationStatus = false;

        user1.Age = 22;
        user2.Age = "35 - 40";

        System.Console.WriteLine(user1.RegistrationStatus);
        System.Console.WriteLine(user2.RegistrationStatus);

        System.Console.WriteLine(user1.Age);    
        System.Console.WriteLine(user2.Age);

        System.Console.ReadKey();
    }
}