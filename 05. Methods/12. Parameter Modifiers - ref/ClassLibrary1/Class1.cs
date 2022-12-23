public class Product
{
    //fields
    private int productID;
    private string productName;
    private double cost;
    private double tax;
    private int quantityInStock;
    public static int TotalNoProducts;
    public const string CategoryName = "Electronics";
    private readonly string dateOfPurchase;

    //constructor
    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();
    }

    //Set method for productID
    public void SetProductID(int productID)
    {
        this.productID = productID;
    }

    //Get method for productID
    public int GetProductID()
    {
        return productID;
    }

    //Set method for productName
    public void SetProductName(string value)
    {
        productName = value;
    }

    //Get method for productName
    public string GetProductName()
    {
        return productName;
    }

    //Set method for cost
    public void SetCost(double value)
    {
        cost = value;
    }

    //Get method for cost
    public double GetCost()
    {
        return cost;
    }

    //Set method for tax
    public void SetTax(double value)
    {
        tax = value;
    }

    //Get method for tax
    public double GetTax()
    {
        return tax;
    }

    //CalculateTax method to calculate tax
    /*cost <= 20000  then  tax = 10%
    cost > 20000 then  tax = 12.5%*/
    public void CalculateTax(ref double percentage)
    {
        percentage = 10.45;

        //create local variable
        double t;

        //calculate tax
        if (this.cost <= 20000)
        {
            t = cost * 10 / 100;
        }
        else
        {
            t = cost * percentage / 100;
        }
        tax = t;
    }

    public void CalculateTax(double cost, double percentage)
    {
        //create local variable
        double t;

        //calculate tax
        if (cost <= 50000)
        {
            t = cost * 5 / 100;
        }
        else
        {
            t = cost * percentage / 100;
        }
        tax = t;
    }


    //Set method for quantityInStock
    public void SetQuantityInStock(int value)
    {
        quantityInStock = value;
    }

    //Get method for quantityInStock
    public int GetQuantityInStock()
    {
        return quantityInStock;
    }

    //Get method for dateOfPurchase
    public string GetDateOfPurchase()
    {
        return dateOfPurchase;
    }

    //static method: Set method of TotalNoOfProducts
    public static void SetTotalNoOfProducts(int value)
    {
        TotalNoProducts = value;
    }

    //static method: Get method of TotalNoOfProducts
    public static int GetTotalNoOfProducts()
    {
        return TotalNoProducts;
    }


    //static method: Calculates Total Quantity
    public static int GetTotalQuantity(Product product1, Product product2, Product product3)
    {
        int total;
        total = product1.GetQuantityInStock() + product2.GetQuantityInStock() + product3.GetQuantityInStock();
        return total;
    }
}

