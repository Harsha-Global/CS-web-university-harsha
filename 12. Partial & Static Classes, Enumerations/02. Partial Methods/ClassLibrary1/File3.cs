namespace Warehouse
{
    public partial class Product
    {
        //implementation of partial method
        partial void GetTax()
        {
            double tax = Cost * 10 / 100;
            System.Console.WriteLine(tax);
        }
    }
}

