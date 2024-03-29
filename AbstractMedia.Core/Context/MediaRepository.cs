﻿using System;
using System.Collections.Generic;
using AbstractMedia.Core.Models;
using System.Linq;

namespace AbstractMedia.Core.Context;

public class MediaRepository : IMediaRepository
{
    private readonly IMediaContext _context;

    public MediaRepository(IMediaContext context)
    {
        _context = context;
    }

    public void AddMedia(Media media)
    {
        _context.AddMedia(media);
        _context.SaveChanges();
    }

    // TODO: Implement the FindMedia method
    public Media FindMedia(string type, string title)
    {
        // Instructions:
        // 1. Loop through each media item in the _context.Media list.
        // 2. For each media item, check if its type matches the 'type' parameter (case-insensitive) and its title matches the 'title' parameter (case-insensitive).
        // 3. If a match is found, return the media item.
        // 4. If no match is found after checking all media items, return null.

        // Your code starts here.

        foreach (var media in _context.Media)
        {
            if(media.GetType().Name.Equals(type, StringComparison.InvariantCultureIgnoreCase)
                && media.Title.Equals(title, StringComparison.InvariantCultureIgnoreCase))
            {
                return media;
            }
        }

        // Your code ends here.

        return null;
    }

    public IEnumerable<Media> GetAllMedia()
    {
        return _context.Media;
    }

    public IEnumerable<Media> SearchMedia(string title)
    {
        //Your code here

        return _context.Media.Where(media => media.Title.ToLower() == title.ToLower()).ToList();
        
        
    }
}
