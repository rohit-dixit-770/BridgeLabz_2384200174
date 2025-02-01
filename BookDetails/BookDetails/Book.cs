using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDetails
{
    public class Book
    {
        // Fields (Attributes)
        private string title;
        private string author;
        private double price;

        // constructor
        public Book(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        // method to display result
        public void DisplayDetails()
        {
            Console.WriteLine("Book Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: " + price);
        }
    }
}
