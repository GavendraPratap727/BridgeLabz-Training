using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.BookBuddy
{
    interface IBookActions
    {
        void AddBook(string title, string author);
        void Search(string author);
        void SortBooks();
        void DisplayBooks();
    }

}
