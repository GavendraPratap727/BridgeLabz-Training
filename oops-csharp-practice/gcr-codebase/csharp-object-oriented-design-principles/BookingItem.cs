using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace bridge.lkfdghkjf
{
    class BookItem
    {
        public string title;
        public string author;

        // sets book details
        public BookItem(string title, string author)
        {
            this.title = title;
            this.author = author;
        }
    }

    // represents a library that holds books
    class BookStore
    {
        public string name;
        public List<BookItem> list;

        // creates a new library
        public BookStore(string name)
        {
            this.name = name;
            list = new List<BookItem>();
        }

        // adds a book to library
        public void add(BookItem book)
        {
            list.Add(book);
        }

        // prints all books in library
        public void show()
        {
            System.Console.WriteLine("Library: " + name);

            foreach (BookItem b in list)
            {
                System.Console.WriteLine(b.title + " by " + b.author);
            }

            System.Console.WriteLine();
        }
    }

    // 
    class BookingItem
    {
        // main method
        static void Main(string[] args)
        {
            BookItem b1 = new BookItem("Rich Dad Poor Dad", "Rishita");
            BookItem b2 = new BookItem("Atomic Habits", "James Clear");
            BookStore lib1 = new BookStore("Central Library");
            BookStore lib2 = new BookStore("Gate 2 Library");
            lib1.add(b1);
            lib1.add(b2);
            lib2.add(b2);
            lib1.show();
            lib2.show();
        }
    }









}
