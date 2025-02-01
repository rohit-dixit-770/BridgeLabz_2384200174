using System;

namespace BookDetails
{
    class Program 
    {
        public static void Main(string[] args)
        {
            // create Book class object
            Book book = new Book("C# Programming", "Rohit Dixit", 100);

            // display result
            book.DisplayDetails();
        }
    }
}
