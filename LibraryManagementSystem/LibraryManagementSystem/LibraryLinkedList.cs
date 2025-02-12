using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class LibraryLinkedList
    {
        private BookNode head;
        private BookNode tail; 
        public LibraryLinkedList()
        {
            head = null;
            tail = null;
        }

        // Add a new book at the beginning
        public void AddAtBeginning(string bookTitle, string author, string genre, int bookID, bool isAvailable)
        {
            BookNode newNode = new BookNode(bookTitle, author, genre, bookID, isAvailable);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Prev = newNode;
                head = newNode;
            }
        }

        // Add a new book at the end
        public void AddAtEnd(string bookTitle, string author, string genre, int bookID, bool isAvailable)
        {
            BookNode newNode = new BookNode(bookTitle, author, genre, bookID, isAvailable);
            if (tail == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }
        }

        // Add a new book at a specific position
        public void AddAtPosition(string bookTitle, string author, string genre, int bookID, bool isAvailable, int position)
        {
            if (position == 0)
            {
                AddAtBeginning(bookTitle, author, genre, bookID, isAvailable);
                return;
            }

            BookNode newNode = new BookNode(bookTitle, author, genre, bookID, isAvailable);
            BookNode current = head;
            for (int i = 0; i < position - 1; i++)
            {
                if (current == null)
                {
                    Console.WriteLine("Position out of bounds.");
                    return;
                }

                current = current.Next;
            }

            newNode.Next = current.Next;
            if (current.Next != null)
            {
                current.Next.Prev = newNode;
            }
            newNode.Prev = current;
            current.Next = newNode;
        }

        // Remove a book by Book ID
        public void RemoveByBookID(int bookID)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            BookNode current = head;
            while (current != null && current.BookID != bookID)
            {
                current = current.Next;
            }

            if (current == null)
            {
                Console.WriteLine("Book with given ID not found.");
                return;
            }

            if (current.Prev != null)
            {
                current.Prev.Next = current.Next;
            }
            else
            {
                head = current.Next;
            }

            if (current.Next != null)
            {
                current.Next.Prev = current.Prev;
            }
            else
            {
                tail = current.Prev;
            }
        }

        // Search for a book by Book Title
        public BookNode SearchByBookTitle(string bookTitle)
        {
            BookNode current = head;
            while (current != null)
            {
                if (current.BookTitle.Equals(bookTitle, StringComparison.OrdinalIgnoreCase))
                {
                    return current;
                }

                current = current.Next;
            }

            return null;
        }

        // Search for a book by Author
        public BookNode SearchByAuthor(string author)
        {
            BookNode current = head;
            while (current != null)
            {
                if (current.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
                {
                    return current;
                }

                current = current.Next;
            }

            return null;
        }

        // Update a book's Availability Status
        public void UpdateAvailabilityStatus(int bookID, bool isAvailable)
        {
            BookNode book = head;
            while (book != null)
            {
                if (book.BookID == bookID)
                {
                    book.IsAvailable = isAvailable;
                    return;
                }
                book = book.Next;
            }

            Console.WriteLine("Book with given ID not found.");
        }

        // Display all books in forward order
        public void DisplayAllBooksForward()
        {
            BookNode current = head;
            while (current != null)
            {
                Console.WriteLine(current.ToString());
                current = current.Next;
            }
        }

        // Display all books in reverse order
        public void DisplayAllBooksReverse()
        {
            BookNode current = tail;
            while (current != null)
            {
                Console.WriteLine(current.ToString());
                current = current.Prev;
            }
        }

        // Count the total number of books in the library
        public int CountTotalBooks()
        {
            int count = 0;
            BookNode current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }
    }

}
