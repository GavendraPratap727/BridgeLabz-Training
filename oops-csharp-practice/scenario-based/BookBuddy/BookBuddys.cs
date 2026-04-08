using bridge.Opps_senario.BookBuddy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario
{
    internal class BookBuddys
    {
        static void Main(string[] args)
        {
            IBookActions utility = new BookUtility();
            BookMenu menu = new BookMenu(utility);
            menu.ShowMenu();
        }
    }
}
