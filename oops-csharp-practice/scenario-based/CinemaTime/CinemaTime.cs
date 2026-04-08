using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.CinemaTime
{
    internal class CinemaTime
    {
        static void Main(string[] args)
        {
            IMovieFunctionality cinemaService = new SchedulerImpl();
            CinemaMenu menu = new CinemaMenu(cinemaService);
            menu.ShowMenu();
        }
    }
}
