using System;

class Book
{
    // Static variable 
    private static string libraryName = "GLA Library";

    // Readonly variable 
    private readonly string isbn;
    
    // Instance variables 
    private string title;
    private string author;

    // Constructor 
    public Book(string title, string author, string isbn)
    { 
        this.title = title;
        this.author = author;
        this.isbn = isbn;
    }

    // Static method to display library name
    public static void DisplayLibraryName()
    { 
        Console.WriteLine("Library Name :" + libraryName);
    }

    // Method to display book details
    public void DisplayBookDetails()
    {
        if (this is Book)
        {
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Author: " + this.author);
            Console.WriteLine("ISBN: " + this.isbn);
        }
        else
        {
            Console.WriteLine("Invalid book");
        }
    }
	
	public static void Main()
    {
        // Display library name
        Book.DisplayLibraryName();
        
        // Creating book instances
        Book book = new Book("The Last Kingdom", "Rohit", "123456789");
        
        // Display book details
        book.DisplayBookDetails();
    }
}

