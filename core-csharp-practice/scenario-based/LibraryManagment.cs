using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Senario
{
     class LibraryManagment
    {
        //method to find who are u admin or user
        public static void LibraryMenu(string[,] books)
        {
            while (true)
            {
                Console.WriteLine("WHATS YOUR ROLE");
                Console.WriteLine("PRESS 1: FOR ADMIN");
                Console.WriteLine("PRESS 2: FOR USER");
                Console.WriteLine("PRESS 3: FOR EXIT");
                int role = int.Parse(Console.ReadLine());
                switch (role)
                {
                    case 1:
                        AdminMenu(books);
                        break;
                    case 2:
                        UserMenu(books);
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("INVALID INPUT");
                        break;
                }
            }
        }
        //method of user menu which handle all user methods
        public static void UserMenu(string[,] books) {
            while (true)
            {
                Console.WriteLine("PRESS 1: DISPLAY ALL BOOKS");
                Console.WriteLine("PRESS 2: SEARCH BOOK BY TITLE");
                Console.WriteLine("PRESS 3: Back");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        DisplayAllBooks(books);
                        break;
                    case 2:
                        SearchBookByTitle(books);
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("INVALID INPUT");
                        break;
                }
            }
        }
        //method of admin menu which handle all admin methods
        public static void AdminMenu(string[,] books) {
            Console.WriteLine("Enter admin password ");
            int password=int.Parse(Console.ReadLine());
            if (password != 1234) {
                Console.WriteLine("INVALID PASSWORD");
                return;
            }
            while (true) {
                Console.WriteLine("PRESS 1: DISPLAY ALL BOOKS");
                Console.WriteLine("PRESS 2: UPDATE BOOK DETAILS");
                Console.WriteLine("PRESS 3: CHANGE BOOK STATUS");
                Console.WriteLine("PRESS 4: Back");
                int choice=int.Parse(Console.ReadLine());
                switch (choice) {
                    case 1:
                        DisplayAllBooks(books);
                        break;
                    case 2:
                        UpdateBookDetails(books);
                        break;
                    case 3:
                        ChangeBookStatus(books);
                        break;
                    case 4:
                        return;
                        
                    default:
                        Console.WriteLine("INVALID INPUT");
                        break;

                }
            }
        }
        //method to display books
        static void DisplayAllBooks(string[,] books) {
            Console.WriteLine("            All books           ");
            for (int i = 0; i < books.GetLength(0); i++) {
                Console.WriteLine((i + 1) + " . " + books[i, 0] + " - " + books[i, 1] + " - " + books[i, 2]);
            }
            }
        //method to update book details
        static void UpdateBookDetails(string[,] books) {
            DisplayAllBooks(books);
            Console.WriteLine("Enter the book number u want to update ");
            int bookNo=int.Parse(Console.ReadLine())-1;
            if(bookNo<0 || bookNo>=books.GetLength(0)) {
                Console.WriteLine("Invalid Book Number");
                return;
            }
            Console.WriteLine("Enter new title ");
            books[bookNo, 0]=Console.ReadLine();
            Console.WriteLine("Enter new author ");
            books[bookNo, 1]=Console.ReadLine();
            Console.WriteLine("Book details updated successfully");

        }
        //method to change book status
        public static void ChangeBookStatus(string[,] books) {
            DisplayAllBooks(books);
            Console.WriteLine("Enter the book number which status u want to update ");
            int bookNo = int.Parse(Console.ReadLine()) - 1;
            if (bookNo < 0 || bookNo >= books.GetLength(0))
            {
                Console.WriteLine("Invalid Book Number");
                return;
            }
            Console.WriteLine("Enter new status Available or Checked Out ");
            books[bookNo, 2] = Console.ReadLine();
            Console.WriteLine("Book status updated successfully");
        }
        //method to search book by title
        static void SearchBookByTitle(string[,] books) {
            Console.WriteLine("Enter the name of the book  you want to search");
            string title=Console.ReadLine();
            for (int i = 0; i < books.GetLength(0); i++) {
                if (books[i, 0].Equals(title,StringComparison.OrdinalIgnoreCase)) {
                    Console.WriteLine("Book Found: " + books[i, 0] + " -  " + books[i, 1] + " - " + books[i, 2]);
                    break;
                }
            }
        }
        static void Main(String[] args) {
            //sample book data
            string[,] books = { 
                { "The Alchemist", "Paulo Coelho", "Available" },
                { "Clean Code", "Robert Martin", "Available" },
                { "Atomic Habits", "James Clear", "Available" },
                { "Think and Grow Rich", "Napoleon Hill", "Checked Out" },
                { "Rich Dad Poor Dad", "Robert Kiyosaki", "Available" } };
            LibraryMenu( books); // method to call role menu
        }
    }
}
