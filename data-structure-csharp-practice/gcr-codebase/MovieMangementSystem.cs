
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace bridge.LinkedListttt
{
    class MovieMangementSystem
    {
        static LinkedList<(string title, string director, int year, double rating)> movies = new LinkedList<(string, string, int, double)>();
        static void Main(String[] args)
        {
            AddAtStart("Lalu Chand Ki Prem Kahani", "Rama Singh", 2026, 8.4);
            AddAtEnd("Avatar 3", "James Cameron", 2024, 7.9);
            AddAtPosition(2, "Inception", "Christopher Nolan", 2014, 8.8);
            DisplayForward();
            DisplayReverse();
            Console.WriteLine("Search Movie By Director");
            SearchByDirecor("Christopher Nolan");
            Console.WriteLine("Search Movie By Rating");
            SearchByRating(8.4);
            Console.WriteLine("Update Rating");
            Updaterating("Avatar 3", 7.9);
            Console.WriteLine("Remove Movie");
            RemoveByTitle("Inception");
            DisplayForward();

        }
        static void AddAtStart(string title, string director, int year, double rating)
        {
            movies.AddFirst((title, director, year, rating));
        }
        static void AddAtEnd(string title, string director, int year, double rating)
        {
            movies.AddLast((title, director, year, rating));
        }
        static void AddAtPosition(int position, string title, string director, int year, double rating)
        {
            if (position <= 1)
            {
                AddAtStart(title, director, year, rating);
                return;
            }
            var m = movies.First;
            for (int i = 1; i < position - 1 && m != null; i++)
            {
                m = m.Next;
            }
            if (m == null)
            {
                Console.WriteLine("Invalid position");
                return;
            }
            movies.AddAfter(m, (title, director, year, rating));
        }
        static void RemoveByTitle(string title)
        {
            var s = movies.First;
            while (s != null)
            {
                if (s.Value.title == title)
                {
                    movies.Remove(s);
                    Console.WriteLine("Movie removed successfully");
                    return;
                }
                s = s.Next;
            }
            Console.WriteLine("Movie not found");
        }
        static void SearchByDirecor(string director)
        {
            var s = movies.First;
            bool found = false;
            while (s != null)
            {
                if (s.Value.director == director)
                {
                    Console.WriteLine($"Title: {s.Value.title}, Director: {s.Value.director}, Year: {s.Value.year}, Rating: {s.Value.rating}");
                    found = true;
                }
                s = s.Next;
            }
            if (!found)
            {
                Console.WriteLine("No movies found by the given director");
            }
        }
        static void SearchByRating(double rating)
        {
            var s = movies.First;
            bool found = false;
            while (s != null)
            {
                if (s.Value.rating == rating)
                {
                    Console.WriteLine($"Title: {s.Value.title}, Director: {s.Value.director}, Year: {s.Value.year}, Rating: {s.Value.rating}");
                    found = true;
                }
                s = s.Next;
            }
            if (!found)
            {
                Console.WriteLine("No movies found with the given rating");
            }
        }
        static void Updaterating(string title, double newRating)
        {
            var s = movies.First;
            while (s != null)
            {
                if (s.Value.title == title)
                {
                    s.Value = (s.Value.title, s.Value.director, s.Value.year, newRating);
                    Console.WriteLine("Rating updated successfully");
                    return;
                }
                s = s.Next;
            }
            Console.WriteLine("Movie not found");
        }
        static void DisplayForward()
        {
            Console.WriteLine("Movies in Forward Order:");
            foreach (var movie in movies)
            {
                Console.WriteLine($"Title: {movie.title}, Director: {movie.director}, Year: {movie.year}, Rating: {movie.rating}");
            }
        }
        static void DisplayReverse()
        {
            Console.WriteLine("Movies in Reverse Order:");
            var s = movies.Last;
            while (s != null)
            {
                Console.WriteLine($"Title: {s.Value.title}, Director: {s.Value.director}, Year: {s.Value.year}, Rating: {s.Value.rating}");
                s = s.Previous;
            }
        }
    }
}
