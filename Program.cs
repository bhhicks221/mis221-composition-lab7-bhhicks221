using System;
using System.IO;

namespace mis221_composition_lab7_bhhicks221
{
    class Program
    {
        static void Main(string[] args)
        {
            Author myAuthor = new Author("Jeff Lucas", 'm', "jslucas@cba.ua.edu");

            Console.WriteLine(myAuthor.ToString());

            Book myBook = new Book("12243", "My Book, Your Book", myAuthor);
            Console.WriteLine(myBook.ToString());

            Console.WriteLine(myBook.GetAuthor().ToString());

            Book newBook = new Book("4321", "The Phantom Book", new Author("Jamie", 'f', "jamie@mail.com"));
            Console.WriteLine(newBook.ToString());

            newBook.GetAuthor().SetEmail("jamie@crimson.ua.edu");
            Console.WriteLine(newBook.ToString());
        }
    }
}