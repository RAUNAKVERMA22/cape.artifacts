// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        MovieLibrary library = new MovieLibrary();

        library.AddMovie(new Movie("Inception", "Nolan", "SciFi", 148));
        library.AddMovie(new Movie("Interstellar", "Nolan", "SciFi", 169));
        library.AddMovie(new Movie("Titanic", "Cameron", "Romance", 195));
        library.AddMovie(new Movie("Avatar", "Cameron", "SciFi", 162));
        library.AddMovie(new Movie("The Notebook", "Cassavetes", "Romance", 123));

        Console.WriteLine("SciFi Movies:");
        foreach (var movie in library.GetMoviesByGenre("SciFi"))
        {
            Console.WriteLine(movie.Title);
        }
        Console.WriteLine("\nRomance Movies:");
        foreach (var movie in library.GetMoviesByGenre("Romance"))
        {
            Console.WriteLine(movie.Title);
        }

        Console.WriteLine("\nMovies by Nolan:");
        foreach (var movie in library.GetMoviesByDirector("Nolan"))
        {
            Console.WriteLine(movie.Title);
        }

        Console.WriteLine("\nMovies by Cameron:");
        foreach (var movie in library.GetMoviesByDirector("Cameron"))
        {
            Console.WriteLine(movie.Title);
        }

        Console.WriteLine("\nTotal Duration: " + library.GetTotalDuration());
    }
}
