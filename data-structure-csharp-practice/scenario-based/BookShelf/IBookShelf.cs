using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.DSA_Senario.BookShelf
{
    interface IBookShelf
    {
        void AddBook(string genre, string book);
        void RemoveBook(string genre, string book);
        void Display();
    }
}
