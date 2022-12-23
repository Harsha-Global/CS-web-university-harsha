class Sample
{ 
    static void Main()
    {
        //create reference variables
        Product product1, product2, product3;

        //create objects
        product1 = new Product();
        Product.TotalNoProducts++; //1
        product2 = new Product();
        Product.TotalNoProducts++; //2
        product3 = new Product();
        Product.TotalNoProducts++; //3

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

        int totalQuantity = product1.quantityInStock + product2.quantityInStock + product3.quantityInStock;
        System.Console.WriteLine("Total Quantity: " + totalQuantity);
        System.Console.WriteLine("Total no. of products: " + Product.TotalNoProducts);  //Output: 3

        //TO DO: Findout the highest cost of all three products.
        System.Console.ReadKey();
    }
}

