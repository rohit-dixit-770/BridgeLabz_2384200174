using System;

class Product
{
    // Static variable 
    private static double discount = 10; 

    // Readonly variable 
    private readonly int productID;
    
    // Instance variables 
    private string productName;
    private double price;
    private int quantity;

    // Constructor 
    public Product(int productId, string productName, double price, int quantity)
    {
        this.productID = productId;
        this.productName = productName;
        this.price = price;
        this.quantity = quantity;
    }

    // Static method 
    public static void UpdateDiscount(double newDiscount)
    {
        discount = newDiscount;
        Console.WriteLine("discount updated to: " + discount + "%");
    }

    // Method to display product details 
    public void DisplayProductDetails()
    {
        if (this is Product)
        {
            double finalPrice = price - (price * discount / 100);

            Console.WriteLine("Product ID: " + this.productID);
            Console.WriteLine("Name: " + this.productName);
            Console.WriteLine("price (before discount): " + this.price);
            Console.WriteLine("price (after discount): " + finalPrice);
            Console.WriteLine("quantity: " + this.quantity);
        }
        else
        {
            Console.WriteLine("Invalid product");
        }
    }
	
	public static void Main()
    {
        // Updating the discount percentage
        Product.UpdateDiscount(15.0);
        
        // Creating product instances
        Product product = new Product(101, "Laptop", 1000, 5);
        
        // Displaying product details
        product.DisplayProductDetails();

    }
}
