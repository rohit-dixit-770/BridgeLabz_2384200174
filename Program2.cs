using System;
using System.Collections.Generic;

// Abstract class Product
abstract class Product
{
    public string Name { get; protected set; }
    public double Price { get; protected set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public abstract double CalculateDiscount();

    public void DisplayDetails()
    {
        Console.WriteLine("Product: "+Name+", Price: "+Price);
    }
}

// Electronics class
class Electronics : Product
{
    public Electronics(string name, double price) : base(name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.10; // 10% discount
    }
}

// Clothing class
class Clothing : Product
{
    public Clothing(string name, double price) : base(name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.15; // 15% discount
    }
}

// Main class
class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Electronics("Laptop", 1000),
            new Clothing("T-Shirt", 50)
        };

        foreach (var product in products)
        {
            product.DisplayDetails();
            Console.WriteLine("Discount: "+product.CalculateDiscount());
            Console.WriteLine("-----------------");
        }
    }
}
