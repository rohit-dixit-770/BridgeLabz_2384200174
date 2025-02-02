using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorVariableModifier
{
    class Product
    {
        public string productName;
        public double price;
        public static int totalProducts = 0;

        public Product(string productName, double price)
        {
            this.productName = productName;
            this.price = price;
            Product.totalProducts++;
        }

        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product: {this.productName}, Price: {this.price}");
        }

        public static void DisplayTotalProducts()
        {
            Console.WriteLine($"Total Products: {Product.totalProducts}");
        }

        public static void Main()
        {
            Product product = new Product("Shirt", 1100);

            product.DisplayProductDetails();
            Product.DisplayTotalProducts();
        }
    }
}
