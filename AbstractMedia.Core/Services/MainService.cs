using System;

namespace AbstractMedia.Core.Services;

/// <summary>
///     You would need to inject your interfaces here to execute the methods in Invoke()
///     See the commented out code as an example
/// </summary>
public class MainService : IMainService
{
    private readonly IMediaService _mediaService;

    public MainService(IMediaService mediaService)
    {
        _mediaService = mediaService;
    }

    public void Invoke()
    {
        var exit = false;
        while (!exit)
        {
            Console.WriteLine("Welcome to the Media Library!");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Enter new media");
            Console.WriteLine("2. Find media");
            Console.WriteLine("3. List all media of a specific type");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice (1, 2, 3, or 4): ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    _mediaService.EnterNewMedia();
                    break;
                case "2":
                    _mediaService.FindMedia();
                    break;
                case "3":
                    _mediaService.ListMediaByType();
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1, 2, 3, or 4.");
                    break;
            }
        }
    }
}
