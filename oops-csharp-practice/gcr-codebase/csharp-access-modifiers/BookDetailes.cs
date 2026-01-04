using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Access_modifiers
{
    public class BookDetailes
    {
        //member variables
        string titleOfBook;
        string author;
        double price;
        //parameterized constructor
        public BookDetailes(string enteredTitle, string enteredAuthor, double enteredPrice)
        {
            //this refers to the current instance of the class
            this.titleOfBook = enteredTitle;
            this.author = enteredAuthor;
            this.price = enteredPrice;
        }
        //method to display book details
        public void BookDetails()
        {
            Console.WriteLine("Book Details are given below");
            Console.WriteLine("Title of the book is : " + titleOfBook);
            Console.WriteLine("Author of the book is : " + author);
            Console.WriteLine("Price of the book is : " + price);

        }
        //main method
        static void Main(string[] args)
        {
            BookDetailes bo = new BookDetailes("Half girlfriend", "Gavendra", 300);
            bo.BookDetails(); //calling function to display book details
        }
    }
}
