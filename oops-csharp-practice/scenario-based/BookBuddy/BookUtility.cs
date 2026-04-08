using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.BookBuddy
{
    class BookUtility : IBookActions
    {
        private string[] books;
        private int count;
        public BookUtility()
        {
            books = new string[10];
            count = 0;
        }
        public void AddBook(string title, string author)
        {
            if (count >= books.Length)
            {
                Console.WriteLine("Bookshelf is full");
                return;
            }

            books[count] = title + " - " + author;
            count++;
            Console.WriteLine("Book added successfully");
        }
        public void Search(string author)
        {
            if (count == 0)
            {
                Console.WriteLine("Bookshelf is empty");
                return;
            }

            bool found = false;

            for (int i = 0; i < count; i++)
            {
                string[] parts = books[i].Split('-');

                if (parts.Length == 2)
                {
                    string bookAuthor = parts[1].Trim();

                    if (bookAuthor.ToLower().Contains(author.ToLower()))
                    {
                        Console.WriteLine("Found: " + books[i]);
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("No book found for author: " + author);
            }
        }

        public void SortBooks()
        {
            if (count == 0)
            {
                Console.WriteLine("Bookshelf is empty");
                return;
            }

            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (string.Compare(books[i], books[j]) > 0)
                    {
                        string temp = books[i];
                        books[i] = books[j];
                        books[j] = temp;
                    }
                }
            }

            Console.WriteLine("Books sorted successfully");
        }

        public void DisplayBooks()
        {
            if (count == 0)
            {
                Console.WriteLine("Bookshelf is empty");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine((i + 1) + ". " + books[i]);
            }
        }
    }

}
