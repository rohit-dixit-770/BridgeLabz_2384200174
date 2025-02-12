using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class BookNode
    {
        public string BookTitle;
        public string Author;
        public string Genre;
        public int BookID;
        public bool IsAvailable;
        public BookNode Next;
        public BookNode Prev;

        public BookNode(string bookTitle, string author, string genre, int bookID, bool isAvailable)
        {
            BookTitle = bookTitle;
            Author = author;
            Genre = genre;
            BookID = bookID;
            IsAvailable = isAvailable;
            Next = null;
            Prev = null;
        }

        public override string ToString()
        {
            return $"Title: {BookTitle}, Author: {Author}, Genre: {Genre}, Book ID: {BookID}, Available: {IsAvailable}";
        }
    }

}
