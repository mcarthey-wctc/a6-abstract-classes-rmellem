using System;
using AbstractMedia.Core.Context;
using AbstractMedia.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace AbstractMedia.Core;

/// <summary>
///     Used for registration of new interfaces
/// </summary>
public class Startup
{
    public IServiceProvider ConfigureServices()
    {
        IServiceCollection services = new ServiceCollection();

        services.AddLogging(builder =>
        {
            builder.AddConsole();
            builder.AddFile("app.log");
        });

        // Add new lines of code here to register any interfaces and concrete services you create
        services.AddTransient<IMainService, MainService>();
        services.AddScoped<IMediaContext>(provider => new MediaFileContext("Files/media.csv"));
        services.AddSingleton<IMediaRepository, MediaRepository>();
        services.AddTransient<IMediaService, MediaService>();

        return services.BuildServiceProvider();
    }
}
