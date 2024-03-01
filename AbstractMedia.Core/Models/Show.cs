namespace AbstractMedia.Core.Models;

public class Show : Media
{
    public int Episode { get; set; }
    public int Season { get; set; }
    public string[] Writers { get; set; }

    public Show(int id, string title, int season, int episode, string[] writers)
    {
        Id = id;
        Title = title;
        Season = season;
        Episode = episode;
        Writers = writers;
    }

    public override string ToString()
    {
        return $"Show: {Title}, Season: {Season}, Episode: {Episode}, Writers: {string.Join(", ", Writers)}";
    }
}
