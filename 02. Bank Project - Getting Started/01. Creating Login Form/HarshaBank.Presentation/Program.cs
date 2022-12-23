class Program
{
    //Application execution starts here
    static void Main()
    {
        //display title
        System.Console.WriteLine("************** Harsha Bank *****************");
        System.Console.WriteLine("::Login Page::");

        //declare variables to store username and password;
        string userName = null, password = null;

        //read userName from keyboard
        System.Console.Write("Username: ");
        userName = System.Console.ReadLine();

        //read password from keyboard only if username is entered
        if (userName != "")
        {
            System.Console.Write("Password: ");
            password = System.Console.ReadLine();
        }
        
        //check username and password
        if (userName == "system" && password == "manager")
        {
            System.Console.WriteLine("TO DO: Main menu here");
        }

        //about to exit
        System.Console.WriteLine("Thank you! Visit again.");
        System.Console.ReadKey();
    }
}