using System;
using System.Collections.Generic;
using System.Linq;
namespace Movie_Stock;
class Program
{
    public static List<Movie> MovieList = new List<Movie>();

    static void Main()
    {
        Console.Write("Enter number of movies: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter movie details (Title,Artist,Genre,Rating):");
            string details = Console.ReadLine();
            AddMovie(details);
        }

        Console.Write("Enter genre to search: ");
        string genre = Console.ReadLine();

        List<Movie> genreMovies = ViewMoviesByGenre(genre);

        if (genreMovies.Count == 0)
        {
            Console.WriteLine($"No Movies found in genre {genre}");
        }
        else
        {
            foreach (Movie m in genreMovies)
            {
                Console.WriteLine($"{m.Title},{m.Artist},{m.Genre},{m.Rating}");
            }
        }

        Console.WriteLine("Movies sorted by rating:");
        List<Movie> sortedMovies = ViewMoviesByRating();
        foreach (Movie m in sortedMovies)
        {
            Console.WriteLine($"{m.Title},{m.Artist},{m.Genre},{m.Rating}");
        }
    }

    // Method 1
    public static void AddMovie(string movieDetails)
    {
        string[] data = movieDetails.Split(',');

        Movie movie = new Movie
        {
            Title = data[0],
            Artist = data[1],
            Genre = data[2],
            Rating = int.Parse(data[3])
        };

        MovieList.Add(movie);
    }

    // Method 2
    public static List<Movie> ViewMoviesByGenre(string genre)
    {
        return MovieList
               .Where(m => m.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase))
               .ToList();
    }

    // Method 3
    public static List<Movie> ViewMoviesByRating()
    {
        return MovieList
               .OrderBy(m => m.Rating)
               .ToList();
    }
}
