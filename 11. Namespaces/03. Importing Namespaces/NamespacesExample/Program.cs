using HR;
using HR.Mgr;
using FrontOffice;

class Program
{
    static void Main()
    {
        //creating objects of Manager class
        IManager manager1;
        manager1 = new Manager();

        IManager manager2;
        manager2 = new Manager();

        IManager manager3;
        manager3 = new Manager();


        //Creating objects of CustomerEnquiry class
        CustomerEnquiry customerEnquiry = new CustomerEnquiry();

        System.Console.ReadKey();
    }
}

