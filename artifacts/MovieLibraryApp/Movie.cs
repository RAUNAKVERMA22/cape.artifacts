// Movie.cs
public class Movie : IMovie
{
    public string Title { get; set; }
    public string Director { get; set; }
    public string Genre { get; set; }
    public int Duration { get; set; }

    public Movie(string title, string director, string genre, int duration)
    {
        Title = title;
        Director = director;
        Genre = genre;
        Duration = duration;
    }
}
