using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.CinemaTime
{
    internal class CinemaMenu
    {
        private IMovieFunctionality cinema;
        public CinemaMenu(IMovieFunctionality cinemaService)
        {
            this.cinema = cinemaService;
        }
        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("PRESS 1: Add Movie");
                Console.WriteLine("PRESS 2: Search Movie");
                Console.WriteLine("PRESS 3: Display All Movies");
                Console.WriteLine("PRESS 4 Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the movie title ");
                        string title = Console.ReadLine();
                        Console.Write("Enter show time: ");
                        string time = Console.ReadLine();
                        cinema.AddMovie(title, time);
                        break;
                    case 2:
                        Console.Write("Enter keyword to search YOUR MOVIE ");
                        string keyword = Console.ReadLine();
                        cinema.SearchMovie(keyword);
                        break;
                    case 3:
                        cinema.DisplayAllMovies();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
