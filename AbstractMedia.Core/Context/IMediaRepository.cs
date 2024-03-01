using System.Collections.Generic;
using AbstractMedia.Core.Models;

namespace AbstractMedia.Core.Context;

public interface IMediaRepository
{
    void AddMedia(Media media);
    Media FindMedia(string type, string title);
    IEnumerable<Media> GetAllMedia();
}
