using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.CinemaTime
{
    internal interface IMovieFunctionality
    {
        void AddMovie(string movieTitle, string movieShowTime);
        void SearchMovie(string keyword);
        void DisplayAllMovies();
    }
}
