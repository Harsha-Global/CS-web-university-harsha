using static System.Console;
using Warehouse;

class Program
{
    static void Main()
    {
        //create object of Partial class
        Product product = new Product();

        //access properties
        product.ProductID = 101;
        product.Cost = 1000;

        //access methods
        product.CallGetTax();

        ReadKey();
    }
}