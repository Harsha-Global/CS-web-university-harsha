using HR;
using m = HR.Mgr;
using FrontOffice;
using static System.Console;

class Program
{
    static void Main()
    {
        //Creating objects of Manager class
        WriteLine("Manager class");
        m.IManager manager1;
        manager1 = new m.Manager();

        m.IManager manager2;
        manager2 = new m.Manager();

        m.IManager manager3;
        manager3 = new m.Manager();


        //Creating objects of CustomerEnquiry class
        WriteLine("CustomerEnquiry class");
        CustomerEnquiry customerEnquiry = new CustomerEnquiry();

        ReadKey();
    }
}

