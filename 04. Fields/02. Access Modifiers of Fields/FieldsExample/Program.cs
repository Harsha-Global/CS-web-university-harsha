class Sample
{ 
    static void Main()
    {
        //create reference variables
        Product product1, product2, product3;

        //create objects
        product1 = new Product();
        product2 = new Product();
        product3 = new Product();

        //initalize fields
        product1.productID = 1001;
        product1.productName = "Mobile";
        product1.cost = 20000;
        product1.quantityInStock = 1200;
        product2.productID = 1003;
        product2.productName = "Laptop";
        product2.cost = 45000;
        product2.quantityInStock = 3400;
        product3.productID = 1003;
        product3.productName = "Speakers";
        product3.cost = 36000;
        product3.quantityInStock = 800;

        //get values from fields
        System.Console.WriteLine("Product 1:");
        System.Console.WriteLine("Product ID: " + product1.productID);
        System.Console.WriteLine("Product Name: " + product1.productName);
        System.Console.WriteLine("Cost: " + product1.cost);
        System.Console.WriteLine("Quantity in Stock: " + product1.quantityInStock);

        System.Console.WriteLine("\nProduct 2:");
        System.Console.WriteLine("Product ID: " + product2.productID);
        System.Console.WriteLine("Product Name: " + product2.productName);
        System.Console.WriteLine("Cost: " + product2.cost);
        System.Console.WriteLine("Quantity in Stock: " + product2.quantityInStock);

        System.Console.WriteLine("\nProduct 3:");
        System.Console.WriteLine("Product ID: " + product3.productID);
        System.Console.WriteLine("Product Name: " + product3.productName);
        System.Console.WriteLine("Cost: " + product3.cost);
        System.Console.WriteLine("Quantity in Stock: " + product3.quantityInStock);

        System.Console.ReadKey();
    }
}

//Child class at other assembly
public class InternationalProduct : Product
{
    public void Method1()
    {
        productID = 1 //not valid
        productName = "abc"; //accessible
        cost = 2000; //valid
        quantityInStock = 10; //accessible
    }
}

//Other class at other assembly
public class OtherClass2
{
    public void Method1()
    {
        Product product = new Product();
        product.productID = 1 //not valid
        product.productName = "abc"; //not valid
        product.cost = 2000; //not valid
        product.quantityInStock = 10; //accessible
    }
}
