using System;
using System.Collections.Generic;
// a) muutetaan Exercise 2 vähän
// Toteuta Movie luokalle konstruktori, joka ottaa parametreiksi SetMovieInformation() -funktion tapaan luokalle alustettavat attribuutit.
// b) Muutetaan myös seuraavaksi MovieRental -luokan rakennetta.
// Toteutetaan MovieRental luokalle seuraavat asiat:
// public string name; public get private set
// Konstruktori, joka ottaa funktion parametriksi string muuttujan, ja alustaa name muuttujan konstruktorin sisällä. Alusta myös movies lista konstruktorin sisällä.
namespace Exercise3
{

    // Exercise 3 Constructors, continues from Ex 2

    // Movie class private string title = "None", Movie title...
    class Movie
    {
        public string title = "None";
        public int duration = 0;
        public int releaseYear = 0;
        private string genre = "None";
        private string description = "None";

        // Set movie Information: Title, duration (minutes), release year, genre

        public Movie(string mTitle, int mDuration, int mReleaseYear, string mGenre)
        {
            title = mTitle;
            duration = mDuration;
            releaseYear = mReleaseYear;
            genre = mGenre;
        }
        public void SetGenre(string mGenre)
        {
            genre = mGenre;
        }
        public string GetGenre()
        {
            return genre;
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
        public string name { get; set; } = "";

        public MovieRental(string mrName)
        {
            name = mrName;
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
            Movie horrorMovie = new Movie("Programmer", 90, 2021, "Horror");
            Movie scifiMovie = new Movie("Artist", 180, 2021, "Comedy");

            MovieRental movieRental = new MovieRental("The Watchers Club");

            movieRental.AddMovie(horrorMovie);
            movieRental.AddMovie(scifiMovie);

            movieRental.RentableMovies();
        }
    }
}