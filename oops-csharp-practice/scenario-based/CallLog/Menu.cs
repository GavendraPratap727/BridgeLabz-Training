using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.CallLog
{
     class Menu:IAppRunner
    {
        ICallLogService addservice=new CallLogService();
        ISearchService searchservice=new SearchService();
        IFilterService filterService=new FilterService();
        public void ShowMenu() {
            while (true) {
                Console.WriteLine("PRESS 1 : FOR ADD LOG");
                Console.WriteLine("PRESS 2 : FOR SEARCH LOG");
                Console.WriteLine("PRESS 3 : FOR FILTER LOG BY TIME RANGE");
                Console.WriteLine("PRESS 4 : EXIT");
                int choice=int.Parse(Console.ReadLine());
                switch (choice) {
                    case 1:
                        addservice.AddLog();
                        break;
                    case 2:
                        Console.WriteLine("Enter keyword for search");
                        string keyword=Console.ReadLine();
                        searchservice.Search(keyword);
                        break;
                    case 3:
                        Console.Write("Start date (yyyy-mm-dd): ");
                        DateTime start = DateTime.Parse(Console.ReadLine());
                        Console.Write("End date (yyyy-mm-dd): ");
                        DateTime end = DateTime.Parse(Console.ReadLine());
                        filterService.Filter(start, end);
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }

            }
        }

    }
}
