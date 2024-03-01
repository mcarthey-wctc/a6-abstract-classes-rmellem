using System;
using System.Linq;
using AbstractMedia.Core.Context;
using AbstractMedia.Core.Models;

namespace AbstractMedia.Core.Services;

public class MediaService : IMediaService
{
    private readonly IMediaRepository _mediaRepository;

    public MediaService(IMediaRepository mediaRepository)
    {
        _mediaRepository = mediaRepository;
    }

    public void EnterNewMedia()
    {
        Console.WriteLine("Enter the type of media (Movie, Show, Video): ");
        var type = Console.ReadLine();
        Console.WriteLine("Enter the title: ");
        var title = Console.ReadLine();

        switch (type.ToLower())
        {
            case "movie":
                Console.WriteLine("Enter genres (separated by commas): ");
                var genres = Console.ReadLine().Split(',');
                var movie = new Movie(_mediaRepository.GetAllMedia().Count() + 1, title, genres);
                _mediaRepository.AddMedia(movie);
                break;
            case "show":
                Console.WriteLine("Enter season number: ");
                var season = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter episode number: ");
                var episode = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter writers (separated by commas): ");
                var writers = Console.ReadLine().Split(',');
                var show = new Show(_mediaRepository.GetAllMedia().Count() + 1, title, season, episode, writers);
                _mediaRepository.AddMedia(show);
                break;
            case "video":
                Console.WriteLine("Enter format: ");
                var format = Console.ReadLine();
                Console.WriteLine("Enter length (in minutes): ");
                var length = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter regions (separated by commas): ");
                var regions = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);
                var video = new Video(_mediaRepository.GetAllMedia().Count() + 1, title, format, length, regions);
                _mediaRepository.AddMedia(video);
                break;
            default:
                Console.WriteLine("Invalid media type.");
                break;
        }
    }

    public void FindMedia()
    {
        Console.WriteLine("Enter the type of media (Movie, Show, Video): ");
        var type = Console.ReadLine();
        Console.WriteLine("Enter the title: ");
        var title = Console.ReadLine();

        var media = _mediaRepository.FindMedia(type, title);
        if (media != null)
        {
            Console.WriteLine(media.ToString());
        }
        else
        {
            Console.WriteLine("Media not found.");
        }
    }

    public void ListMediaByType()
    {
        Console.WriteLine("Enter the type of media (Movie, Show, Video): ");
        var type = Console.ReadLine();

        var mediaList = _mediaRepository.GetAllMedia();

        switch (type.ToLower())
        {
            case "movie":
                var movies = mediaList.OfType<Movie>();
                foreach (var movie in movies)
                {
                    Console.WriteLine(movie.ToString());
                }

                break;
            case "show":
                var shows = mediaList.OfType<Show>();
                foreach (var show in shows)
                {
                    Console.WriteLine(show.ToString());
                }

                break;
            case "video":
                var videos = mediaList.OfType<Video>();
                foreach (var video in videos)
                {
                    Console.WriteLine(video.ToString());
                }

                break;
            default:
                Console.WriteLine("Invalid media type.");
                break;
        }
    }
}
