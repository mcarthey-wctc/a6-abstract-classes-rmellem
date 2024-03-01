using System.Collections.Generic;
using AbstractMedia.Core.Models;

namespace AbstractMedia.Core.Context;

public interface IMediaContext
{
    List<Media> Media { get; set; }

    // CRUD operations
    void AddMedia(Media media);
    void DeleteMedia(Media media);
    Media GetMediaById(int id);

    void SaveChanges();
    void UpdateMedia(Media media);
}
