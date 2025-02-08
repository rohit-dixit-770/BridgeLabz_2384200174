using System;
public class Order
{
    public string OrderId { get; set; }
    public DateTime OrderDate { get; set; }

    // Constructor
    public Order(string orderId, DateTime orderDate)
    {
        this.OrderId = orderId;
        this.OrderDate = orderDate;
    }

    // Virtual method to get order status
    public virtual string GetOrderStatus()
    {
        return "Order Placed";
    }

    // Method to display order details
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Order ID: "+OrderId+", Order Date: "+OrderDate);
    }
}

public class ShippedOrder : Order
{
    public string TrackingNumber { get; set; }

    // Constructor 
    public ShippedOrder(string orderId, DateTime orderDate, string trackingNumber)
        : base(orderId, orderDate)
    {
        this.TrackingNumber = trackingNumber;
    }

    // Overriding the GetOrderStatus method
    public override string GetOrderStatus()
    {
        return "Order Shipped";
    }

    // Overriding the DisplayDetails method t
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Tracking Number: "+TrackingNumber);
    }
}

public class DeliveredOrder : ShippedOrder
{
    public DateTime DeliveryDate { get; set; }

    // Constructor 
    public DeliveredOrder(string orderId, DateTime orderDate, string trackingNumber, DateTime deliveryDate)
        : base(orderId, orderDate, trackingNumber)
    {
        this.DeliveryDate = deliveryDate;
    }

    // Overriding the GetOrderStatus method
    public override string GetOrderStatus()
    {
        return "Order Delivered";
    }

    // Overriding the DisplayDetails method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Delivery Date: "+DeliveryDate);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of DeliveredOrder
        DeliveredOrder deliveredOrder = new DeliveredOrder("N12345", DateTime.Now.AddDays(-5), "R987654", DateTime.Now);

        // Displaying order details
        deliveredOrder.DisplayDetails();

        // Getting the order status
        Console.WriteLine("Order Status: "+deliveredOrder.GetOrderStatus());
    }
}

