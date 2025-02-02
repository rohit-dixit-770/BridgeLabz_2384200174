using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorVariableModifier
{
    class LibraryBook
    {
        public string title;
        public string author;
        public double price;
        public bool availability;

        public LibraryBook(string title, string author, double price, bool availability)
        {
            this.title = title;
            this.author = author;
            this.price = price;
            this.availability = availability;
        }

        public void BorrowBook()
        {
            if (availability)
            {
                availability = false;
                Console.WriteLine($"{this.title} has been borrowed");
            }
            else
            {
                Console.WriteLine($"{this.title} is not available");
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Book title: " + this.title);
            Console.WriteLine("Book author: " + this.author);
            Console.WriteLine("Book price: " + this.price);
            Console.WriteLine("Book availability: " + this.availability);
        }

        public static void Main()
        {
            // create object of LibraryBook class
            LibraryBook lb = new LibraryBook("The Last Kingdom", "Rohit", 100, true);

            lb.DisplayDetails();
        }
    }

}
