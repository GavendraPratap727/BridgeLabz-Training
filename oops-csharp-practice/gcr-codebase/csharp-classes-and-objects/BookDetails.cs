using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.class_and_object
{
    public class Book
    {
        private string title;
        private string author;
        private double price;
        // Constructor to initialize book details

        public Book(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }
        //
        // Method to display book details
        public void PrintDetails()
        {
            Console.WriteLine();
            Console.WriteLine("Details of the book");
            Console.WriteLine("Title " + this.title);
            Console.WriteLine("Author " + this.author);
            Console.WriteLine("Price " + this.price);
            Console.WriteLine();
        }
    }

    public class BookDetails
    {
        // Main Method
        public static void Main(string[] args)
        {
            Book book1 = new Book("Atomic ", "Hitler", 189);
            Book book2 = new Book("Half GirlFriend", "Chetan bhagat", 169);
            book1.PrintDetails(); // Display book1 details
            book2.PrintDetails(); // Display book2 details
        }
    }
}
