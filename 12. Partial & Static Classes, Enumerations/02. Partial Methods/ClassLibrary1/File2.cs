namespace Warehouse
{
    public partial class Product
    {
        //private field
        private double _cost;

        //public property
        public double Cost
        {
            set
            {
                _cost = value;
            }
            get
            {
                return _cost;
            }
        }

        //public method to call partial method
        public void CallGetTax()
        {
            GetTax();
        }

    }
}
