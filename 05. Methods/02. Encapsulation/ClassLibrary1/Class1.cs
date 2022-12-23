public class Product
{
    //fields
    public int productID;
    public string productName;
    public double cost;
    public double tax;
    public int quantityInStock;
    public static int TotalNoProducts;
    public const string CategoryName = "Electronics";
    public readonly string dateOfPurchase;

    //constructor
    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();
    }

    //Set method for productID
    public void SetProductID(int value)
    {
        productID = value;
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
    public void CalculateTax()
    {
        //create local variable
        double t;

        //calculate tax
        if (cost <= 20000)
        {
            t = cost * 10 / 100;
        }
        else
        {
            t = cost * 12.5 / 100;
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
}

