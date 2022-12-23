namespace Warehouse
{
    public partial class Product
    {
        //private field
        private int _productID;

        //public property
        public int ProductID
        {
            set
            {
                _productID = value;
            }
            get
            {
                return _productID;
            }
        }

        //declaration of partial method
        partial void GetTax();
    }
}



