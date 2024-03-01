namespace AbstractMedia.Core.Models;

public class Movie : Media
{
    public string[] Genres { get; set; }

    public Movie(int id, string title, string[] genres)
    {
        Id = id;
        Title = title;
        Genres = genres;
    }

    public override string ToString()
    {
        return $"Movie: {Title}, Genres: {string.Join(", ", Genres)}";
    }
}
