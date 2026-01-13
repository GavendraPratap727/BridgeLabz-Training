using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.BookBuddy
{
    using System;

    class BookMenu
    {
        private IBookActions bookService;

        public BookMenu(IBookActions bookService)
        {
            this.bookService = bookService;
        }
        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("PRESS 1 : Add Book");
                Console.WriteLine("PRESS 2 : Search by Author");
                Console.WriteLine("PRESS 3 : Sort Books");
                Console.WriteLine("PRESS 4 : Display Books");
                Console.WriteLine("PRESS 5 :  Exit");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Write("Enter book title ");
                    string title = Console.ReadLine();
                    Console.Write("Enter author name ");
                    string author = Console.ReadLine();
                    bookService.AddBook(title, author);
                }
                else if (choice == 2)
                {
                    Console.Write("Enter author keyword: ");
                    string author = Console.ReadLine();
                    bookService.Search(author);
                }
                else if (choice == 3)
                {
                    bookService.SortBooks();
                }
                else if (choice == 4)
                {
                    bookService.DisplayBooks();
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Thank you for using BookBuddy");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }
        }
    }

}
