using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Constructor
{
    class Book
    {
        private string title;
        private string author;
        private double price;

        // Default constructors
        internal Book()
        {
            // Setting default values
            this.title = "Default Title";
            this.author = "Default Author";
            this.price = 10.00;
        }

        // Parameterized construtors
        public Book(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        // Method to display book details
        public void BookDetails()
        {
            Console.WriteLine("Book Name " + this.title);
            Console.WriteLine("Book Author Name " + this.author);
            Console.WriteLine("Book Price " + this.price);
        }

        public static void Main(string[] args)
        {
           
            Book defaultBook = new Book();
         
            Book nonDefaultBook = new Book("Half girlfrien", "Gavendra", 220.00);
            defaultBook.BookDetails();
            nonDefaultBook.BookDetails();
        }
    }
}
