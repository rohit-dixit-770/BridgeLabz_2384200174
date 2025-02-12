namespace LibraryManagementSystem
{
    class Program
    {
        static void Main()
        {
            LibraryLinkedList library = new LibraryLinkedList();

            // Add new books
            library.AddAtEnd("Ek Samandar, Mere Andar", "Sanjeev Joshi", "Fiction", 1, true);
            library.AddAtEnd("To Kill a Mockingbird", "Harper Lee", "Fiction", 2, false);
            library.AddAtEnd("Maha Kavithai", "Vairamuthu", "Dystopian", 3, true);

            // Display all books in forward order
            Console.WriteLine("All Books (Forward Order):");
            library.DisplayAllBooksForward();

            // Display all books in reverse order
            Console.WriteLine("\nAll Books (Reverse Order):");
            library.DisplayAllBooksReverse();

            // Search for a book by Book Title
            Console.WriteLine("\nSearch for book with Title 'Maha Kavithai':");
            BookNode book = library.SearchByBookTitle("Maha Kavithai");
            if (book != null)
            {
                Console.WriteLine(book.ToString());
            }
            else
            {
                Console.WriteLine("Book not found.");
            }

            // Update a book's Availability Status
            Console.WriteLine("\nUpdate Availability Status for book with Book ID 2:");
            library.UpdateAvailabilityStatus(2, true);
            library.DisplayAllBooksForward();

            // Remove a book by Book ID
            Console.WriteLine("\nRemove book with Book ID 1:");
            library.RemoveByBookID(1);
            library.DisplayAllBooksForward();

            // Count the total number of books in the library
            Console.WriteLine("\nTotal number of books in the library:");
            int totalBooks = library.CountTotalBooks();
            Console.WriteLine(totalBooks);
            Console.ReadLine();
        }
    }

}