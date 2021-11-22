using System;
using System.IO;
namespace mis221_composition_lab7_bhhicks221
{
    public class Book
    {
        private string title;
        private string isbn;
        public Author author;

        public Book(string title, string isbn, Author author)
        {
            this.title = title;
            this.isbn = isbn;
            this.author = author;
        }
        public void SetAuthor(Author author)
        {
            this.author = author;
        }
        public Author GetAuthor()
        {
            return author;
        }
         public void SetTitle(string title)
        {
            this.title = title;
        }
        public string GetTitle()
        {
            return title;
        }
        public void SetISBN(string isbn)
        {
            this.isbn = isbn;
        }
        public string GetISBN()
        {
            return isbn;
        }
        public override string ToString()
        {
            return "ISBN = " + isbn + " title = " + title + " " + author.ToString();
        }
    }
}