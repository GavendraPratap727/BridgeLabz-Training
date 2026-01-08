using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.LinkedListttt
{
    internal class LibraryManagement
    {
        static LinkedList<(int id, string title, string author, string genre, bool available)> books
           = new LinkedList<(int, string, string, string, bool)>();

        static void Main(string[] args)
        {
            AddAtEnd(1, "Half GirlFriend", "Chetan Bhagat", "Novel", true);
            AddAtEnd(2, "Clean Code", "Robert Martin", "Software", true);
            AddAtBeginning(3, "Harry Potter", "J K Rowling", "Fantasy", false);
            AddAtPosition(2, 4, "The Tempest", "William Sheakspear", "Fantasy", true);
            Console.WriteLine("Books (Forward):");
            ShowForward();
            Console.WriteLine("Books (Reverse):");
            ShowReverse();
            Console.WriteLine("Search by Title:");
            SearchByTitle("Clean Code");
            Console.WriteLine("Search by Author:");
            SearchByAuthor("J K Rowling");
            Console.WriteLine("Update Availability:");
            UpdateAvailability(3, true);
            Console.WriteLine("Remove Book ID 2:");
            RemoveById(2);
            Console.WriteLine("All Books:");
            ShowForward();
            Console.WriteLine("Total Books: " + CountBooks());
        }
        static void AddAtBeginning(int id, string title, string author, string genre, bool available)
        {
            books.AddFirst((id, title, author, genre, available));
        }

        static void AddAtEnd(int id, string title, string author, string genre, bool available)
        {
            books.AddLast((id, title, author, genre, available));
        }

        static void AddAtPosition(int pos, int id, string title, string author, string genre, bool available)
        {
            if (pos <= 1)
            {
                AddAtBeginning(id, title, author, genre, available);
                return;
            }

            var node = books.First;
            int count = 1;

            while (count < pos - 1 && node != null)
            {
                node = node.Next;
                count++;
            }

            if (node == null)
            {
                Console.WriteLine("Position not valid");
                return;
            }

            books.AddAfter(node, (id, title, author, genre, available));
        }

        static void RemoveById(int id)
        {
            var node = books.First;

            while (node != null)
            {
                if (node.Value.id == id)
                {
                    books.Remove(node);
                    Console.WriteLine("Book removed");
                    return;
                }
                node = node.Next;
            }

            Console.WriteLine("Book not found");
        }

        static void SearchByTitle(string title)
        {
            bool found = false;

            foreach (var b in books)
            {
                if (b.title.ToLower() == title.ToLower())
                {
                    Print(b);
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("Book not found");
        }

        static void SearchByAuthor(string author)
        {
            bool found = false;

            foreach (var b in books)
            {
                if (b.author.ToLower() == author.ToLower())
                {
                    Print(b);
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("Book not found");
        }

        static void UpdateAvailability(int id, bool status)
        {
            var node = books.First;

            while (node != null)
            {
                if (node.Value.id == id)
                {
                    node.Value = (node.Value.id, node.Value.title, node.Value.author,
                                  node.Value.genre, status);
                    Console.WriteLine("Availability updated");
                    return;
                }
                node = node.Next;
            }

            Console.WriteLine("Book not found");
        }

        static void ShowForward()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("Library empty");
                return;
            }

            foreach (var b in books)
            {
                Print(b);
            }
        }

        static void ShowReverse()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("Library empty");
                return;
            }

            var node = books.Last;
            while (node != null)
            {
                Print(node.Value);
                node = node.Previous;
            }
        }

        static int CountBooks()
        {
            return books.Count;
        }

        static void Print((int id, string title, string author, string genre, bool available) b)
        {
            Console.WriteLine( " Title " + b.title + " Author " + b.author + " Genre " + b.genre + " Available " + b.available);

        }
    }
}
