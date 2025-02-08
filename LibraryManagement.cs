using System;
// Superclass Book
public class Book
{
    public string Title { get; set; }
    public int PublicationYear { get; set; }

    // Constructor
    public Book(string title, int publicationYear)
    {
        this.Title = title;
        this.PublicationYear = publicationYear;
    }

    // Method to display book information
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Title: "+Title+", Publication Year: "+PublicationYear);
    }
}

// Subclass Author 
public class Author : Book
{
    public string Name { get; set; }
    public string Bio { get; set; }

    // Constructor 
    public Author(string title, int publicationYear, string name, string bio)
        : base(title, publicationYear)
    {
        this.Name = name;
        this.Bio = bio;
    }

    // Overriding the DisplayInfo method
    public override void DisplayInfo()
    {
        base.DisplayInfo();  
        Console.WriteLine("Author: "+Name+", Bio: "+Bio);
    }
}

// Main program 
class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of Author
        Author author = new Author("The Great Wall", 1950, "Tushar", "Indian novelist and short story writer");

        // Displaying book and author information
        author.DisplayInfo();
    }
}
