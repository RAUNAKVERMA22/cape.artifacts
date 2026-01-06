using System.Collections.Generic;

public class MovieLibrary
{
    private List<IMovie> movies;

    public MovieLibrary()
    {
        movies = new List<IMovie>();
    }

    public void AddMovie(IMovie movie)
    {
        movies.Add(movie);
    }

    public List<IMovie> GetMoviesByGenre(string genre)
    {
        List<IMovie> result = new List<IMovie>();

        foreach (IMovie movie in movies)
        {
            if (movie.Genre.Equals(genre, System.StringComparison.OrdinalIgnoreCase))
            {
                result.Add(movie);
            }
        }

        return result;
    }

    public List<IMovie> GetMoviesByDirector(string director)
    {
        List<IMovie> result = new List<IMovie>();

        foreach (IMovie movie in movies)
        {
            if (movie.Director.Equals(director, System.StringComparison.OrdinalIgnoreCase))
            {
                result.Add(movie);
            }
        }

        return result;
    }

    public int GetTotalDuration()
    {
        int total = 0;

        foreach (IMovie movie in movies)
        {
            total += movie.Duration;
        }

        return total;
    }
}
