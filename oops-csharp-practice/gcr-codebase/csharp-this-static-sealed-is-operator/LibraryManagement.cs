using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Seiled_class
{
    // Sealed class Book
    public class Book
    {
        public static string libraryName = "Central City Library";
        public readonly string bN;
        public string title;
        public string author;

        public Book(string Title, string Author, string ISBN)
        {
            this.title = Title;
            this.author = Author;
            this.bN = ISBN;
        }
        // Static method to display library name
        public static void LibraryName()
        {
            Console.WriteLine("Library Name: " + libraryName);
        }
        public void BookDetails(object book)
        {
            if (book is Book)
            {
                Console.WriteLine("Title " + title);
                Console.WriteLine("Author " + author);
                Console.WriteLine("BN " + bN);
            }
            else   Console.WriteLine("Invalid book ");
        }
    }
    // Main class
    class LibraryManagement
    {
        // Main method
        static void Main(string[] args)
        { // Display library name
            Book.LibraryName();
            Book book1 = new Book("Half GirlFriend", "Chaten bhagat", "IS-101");
            Book book2 = new Book("Tempest", "Williom", "IS-104");
            book1.BookDetails(book1); //    Display book1 details
            Console.WriteLine();
            book2.BookDetails(book2); // Display book2 details
        }
    }
}
