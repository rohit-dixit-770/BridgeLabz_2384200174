using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorVariableModifier
{
    class Book
    {
        public string title;
        public string author;
        public double price;

        // Default Constructor
        public Book() 
        {
            this.title = "Unknown";
            this.author = "Unknown";
            this.price = 0.0;
        }

        // Parameterized Constructor
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

        public static void Main()
        {
            // create object of Book class
            Book book1 = new Book();
            Book book2 = new Book("The Last Kingdom", "Rohit", 100);

            book1.DisplayDetails();
            book2.DisplayDetails();
        }
    }
}
