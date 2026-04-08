using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Constructor
{
   
    class LibraryBook
    {
        static long idCount = 0;

        string title;
        string writer;
        double cost;
        bool isFree;
        long id;

        LibraryBook(string title, string writer, double cost)
        {
            this.title = title;
            this.writer = writer;
            this.cost = cost;
            isFree = true;
            id = ++idCount;
        }

        void borrow()
        {
            if (isFree)
            {
                isFree = false;
                Console.WriteLine("Book Borrowed");
            }
            else
            {
                Console.WriteLine("Book not available");
            }
        }
        //  Main Method
        static void Main()
        {
            LibraryBook b1 = new LibraryBook("book1", "author1", 129);
            LibraryBook b2 = new LibraryBook("book2", "author2", 130);
            b1.borrow();
            b2.borrow();
            b1.borrow();
        }
    }

}
