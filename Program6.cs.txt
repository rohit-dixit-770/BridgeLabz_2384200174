using System;
using System.Collections.Generic;

// Abstract class FoodItem
abstract class FoodItem
{
    public string ItemName { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public FoodItem(string itemName, double price, int quantity)
    {
        ItemName = itemName;
        Price = price;
        Quantity = quantity;
    }

    public abstract double CalculateTotalPrice();

    public void DisplayDetails()
    {
        Console.WriteLine("Item: " + ItemName + ", Price: " + Price + ", Quantity: " + Quantity);
    }
}

// VegItem class
class VegItem : FoodItem
{
    public VegItem(string itemName, double price, int quantity) : base(itemName, price, quantity) { }

    public override double CalculateTotalPrice()
    {
        return Price * Quantity;
    }
}

// NonVegItem class
class NonVegItem : FoodItem
{
    public NonVegItem(string itemName, double price, int quantity) : base(itemName, price, quantity) { }

    public override double CalculateTotalPrice()
    {
        return (Price * Quantity) + 20; // Extra charge for non-veg items
    }
}

// Main Program
class Program
{
    static void Main()
    {
        List<FoodItem> foodItems = new List<FoodItem>
        {
            new VegItem("Paneer Butter Masala", 250, 2),
            new NonVegItem("Chicken Biryani", 300, 1)
        };

        foreach (var item in foodItems)
        {
            item.DisplayDetails();
            Console.WriteLine("Total Price: " + item.CalculateTotalPrice());
            Console.WriteLine("-----------------");
        }
    }
}
