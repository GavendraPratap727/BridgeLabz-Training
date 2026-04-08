using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.CinemaTime
{
    internal class SchedulerImpl:IMovieFunctionality
    {
        private string[] movieTitles = new string[10];
        private string[] movieShowTimes = new string[10];
        int count = 0;
        public void AddMovie(string movieTitle, string movieShowTime)
        {
            if (count >= movieTitles.Length) { Console.WriteLine("Movie Addition Space is full"); return; }
            movieTitles[count] = movieTitle;
            movieShowTimes[count] = movieShowTime;
            count++;
            Console.WriteLine("Movie Added Successfully");
        }
        public void SearchMovie(string keyword)
        {
            bool found = false;
            for (int i = 0; i < count; i++)
            {
                if (movieTitles[i].Contains(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Movie found ------ " + movieTitles[i] + " ------ at " + movieShowTimes[i]);
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Movie not found");
            }
        }
        public void DisplayAllMovies()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(i + 1 + " -----------" + movieTitles[i] + " ------------ at  " + movieShowTimes[i]);
            }
        }
    }
}
