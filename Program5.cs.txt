using System;
using System.Collections.Generic;

// Abstract class LibraryItem
abstract class LibraryItem
{
    public string Title { get; set; }
    
    public LibraryItem(string title)
    {
        Title = title;
    }

    public abstract int GetLoanDuration(); // Abstract method
}

// Book class
class Book : LibraryItem
{
    public Book(string title) : base(title) { }

    public override int GetLoanDuration()
    {
        return 14; // Loan duration for books
    }
}

// Magazine class
class Magazine : LibraryItem
{
    public Magazine(string title) : base(title) { }

    public override int GetLoanDuration()
    {
        return 7; // Loan duration for magazines
    }
}

// Main Program
class Program
{
    static void Main()
    {
        List<LibraryItem> items = new List<LibraryItem>
        {
            new Book("The Great Gatsby"),
            new Magazine("National Geographic")
        };

        foreach (var item in items)
        {
            Console.WriteLine("Title: " + item.Title);
            Console.WriteLine("Loan Duration: " + item.GetLoanDuration() + " days");
            Console.WriteLine("-----------------");
        }
    }
}
