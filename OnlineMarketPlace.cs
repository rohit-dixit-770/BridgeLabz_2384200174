using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment1
{
    public class Product<TCategory>
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public TCategory Category { get; set; }

        public Product(string name, double price, TCategory category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public override string ToString() => $"{Name} - {Category} : ${Price:F2}";
    }

    // Category Types
    public class BookCategory
    {
        public string Genre { get; set; }

        public BookCategory(string genre)
        {
            Genre = genre;
        }

        public override string ToString() => Genre;
    }

    public class ClothingCategory
    {
        public string Size { get; set; }

        public ClothingCategory(string size)
        {
            Size = size;
        }

        public override string ToString() => Size;
    }

    // Generic Product Catalog
    public class ProductCatalog
    {
        private List<object> products = new List<object>();

        public void AddProduct<TCategory>(Product<TCategory> product)
        {
            products.Add(product);
        }

        public void DisplayProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }

        public void ApplyDiscount<TCategory>(Product<TCategory> product, double percentage)
        {
            product.Price -= product.Price * (percentage / 100);
        }
    }
}
