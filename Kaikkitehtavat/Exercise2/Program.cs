using System;
using System.Collections.Generic; // For List<T>

namespace exercise2
{

    // Exercise 2 Access modifiers public, private, protected

    // Movie class private string title = "None", Movie title...
    class Movie
    {
        public string title = "None";
        public int duration = 0;
        public int releaseYear = 0;
        private string genre = "None";
        private string description = "None";

        // Set movie Information: Title, duration (minutes), release year, genre

        public void SetMovieInfo(string mTitle, int mDuration, int mReleaseYear, string mGenre)
        {
            title = mTitle;
            duration = mDuration;
            releaseYear = mReleaseYear;
            genre = mGenre;
        }
        public void SetDescription(string mDescription)
        {
            description = mDescription;
        }
        public string GetDescription()
        {
            return description;
        }
        public void PrintMovieInfo()
        {
            Console.WriteLine("Title: {0}", title);
            Console.WriteLine("Duration: {0} minutes", duration);
            Console.WriteLine("The movie released on {0}", releaseYear);
            Console.WriteLine("Genre: {0}", genre);
            Console.WriteLine("Description: {0}", GetDescription()); // You can use GetDescription() or description parameter
            Console.WriteLine(""); //  just an empty line
        }

    }

    class MovieRental
    {
        // Movie list
        private List<Movie> movies;
        public void InitMoviesList()
        {
            movies = new List<Movie>();
        }
        public void AddMovie(Movie movieRef)
        {
            movies.Add(movieRef);
        }

        // Print information of the movies
        public void RentableMovies()
        {
            if (movies.Count == 0)
            {
                Console.WriteLine("There are no movies to rent..");
                return;
            }
            Console.WriteLine("There are " + movies.Count + " movies in the movie rental store right now.");
            Console.WriteLine("Movies that are for renting:\n");

            // Loop movies and print their informations
            foreach (Movie movie in movies)
            {
                movie.PrintMovieInfo(); // << Here we call movie class PrintMovieInfo()
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Create a new movie object, and set description for it
            // Movie movie = new Movie();
            // movie.description = "Blinking is fun"; <<< Cant access, because the variable ins't visible to the main function

            // Create new movie object from the movie class, and SetInformation

            Movie movie_0 = new Movie();
            movie_0.SetMovieInfo("Blink", 100, 2021, "Action");
            movie_0.SetDescription("Blinking is fun");

            // a new movie object, where we don't set any parameters

            Movie movie_1 = new Movie();

            // make a new MovieRental object and add movies to it.

            MovieRental movieRental = new MovieRental();
            movieRental.InitMoviesList();
            movieRental.AddMovie(movie_0);
            movieRental.AddMovie(movie_1);

            // Print rentable movies

            movieRental.RentableMovies();
        }
    }
}
