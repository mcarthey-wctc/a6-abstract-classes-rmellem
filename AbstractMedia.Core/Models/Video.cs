namespace AbstractMedia.Core.Models;

public class Video : Media
{
    public string Format { get; set; }
    public int Length { get; set; }
    public int[] Regions { get; set; }

    public Video(int id, string title, string format, int length, int[] regions)
    {
        Id = id;
        Title = title;
        Format = format;
        Length = length;
        Regions = regions;
    }

    public override string ToString()
    {
        return $"Video: {Title}, Format: {Format}, Length: {Length} minutes, Regions: {string.Join(", ", Regions)}";
    }
}
