using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConstructorVariableModifier;

namespace ConstructorVariableModifier
{
    class Book
    {
        public string ISBN;
        protected string title;
        private string author;

        public Book(string isbn, string title, string author)
        {
            this.ISBN = isbn;
            this.title = title;
            this.author = author;
        }

        public string GetAuthor()
        {
            return this.author;
        }
        public void SetAuthor(string author)
        {
            this.author = author;
        }
    }

    class EBook : Book
    {
        public string fileFormat;

        public EBook(string isbn, string title, string author, string fileFormat)
            : base(isbn, title, author)
        {
            this.fileFormat = fileFormat;
        }

        public static void Main()
        {
            EBook ebook = new EBook(" 978-3-16-148410-0", "The Last Kingdom", "Rohit", "pdf");
            Console.WriteLine($"ISBN number: {ebook.ISBN}");
            Console.WriteLine($"title: {ebook.title}");
            Console.WriteLine($"author: {ebook.GetAuthor()}");
            Console.WriteLine($"file format: {ebook.fileFormat}");
        }
    }

}
