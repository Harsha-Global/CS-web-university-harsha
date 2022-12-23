namespace Warehouse
{
    public partial class Product
    {
        //public method
        public double GetTax()
        {
            double tax = Cost * 10 / 100;
            return tax;
        }
    }
}

