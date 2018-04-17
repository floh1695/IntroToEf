using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToEf
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new MovieDb();

            // Insert Movies
            db.Movies.AddRange(new Movie[] 
            {
                new Movie { Title = "A", YearReleased = 1997, Genre = "Not Horror", Tagline = "Not Horror", Rating = 0 },
                new Movie { Title = "B", YearReleased = 1997, Genre = "Not Horror", Tagline = "Not Horror", Rating = 0 },
                new Movie { Title = "C", YearReleased = 1998, Genre = "Not Horror", Tagline = "Not Horror", Rating = 0 },
                new Movie { Title = "D", YearReleased = 1988, Genre = "Not Horror", Tagline = "Not Horror", Rating = 0 },
                new Movie { Title = "E", YearReleased = 1988, Genre = "Not Horror", Tagline = "Not Horror", Rating = 0 },
                new Movie { Title = "The Neverending Story", YearReleased = 1955, Genre = "Horror", Tagline = "Horror", Rating = 0 },
                new Movie { Title = "G", YearReleased = 1997, Genre = "Not Horror", Tagline = "Not Horror", Rating = 0 },
                new Movie { Title = "H", YearReleased = 1999, Genre = "Horror", Tagline = "Horror", Rating = 0 },
                new Movie { Title = "I", YearReleased = 1999, Genre = "Not Horror", Tagline = "Not Horror", Rating = 0 },
                new Movie { Title = "J", YearReleased = 1988, Genre = "Horror", Tagline = "Horror", Rating = 0 },
            });
            db.SaveChanges();

            var moviesFrom1988 = db.Movies.Where(movie => movie.YearReleased == 1988);
            foreach (var movieFrom1988 in moviesFrom1988)
            {
                movieFrom1988.Rating = 10;
            }
            db.SaveChanges();

            var theNeverendingStorys = db.Movies.Where(movie => movie.Title == "The Neverending Story");
            foreach (var aNeverendingStory in theNeverendingStorys)
            {
                db.Movies.Remove(aNeverendingStory);
            }

            var horrorMovies = db.Movies.Where(movie => movie.Genre == "Horror");
            foreach (var horrorMovie in horrorMovies)
            {
                Console.WriteLine(horrorMovie.Title);
            }

            Console.ReadLine();
        }
    }
}
