public class Product
{
    //fields
    private int productID;
    protected string productName;
    protected internal double cost;
    public int quantityInStock;
}

//Child class at same assembly
public class DomesticProduct : Product
{
    public void Method1()
    {
        productID= 1 //not valid
        productName = "abc"; //accessible
        cost = 1000; //accessible
        quantityInStock = 10; //accessible
    }
}

//Other class at same assembly
public class OtherClass
{
    public void Method1()
    {
        Product product = new Product();
        product.productID = 1 //not valid
        product.productName = "abc"; //not valid
        product.cost = 2000; //accessible
        product.quantityInStock = 10; //accessible
    }
}
