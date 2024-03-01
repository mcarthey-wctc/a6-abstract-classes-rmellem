# Media Repository Assignment

This assignment involves implementing two methods in the `MediaRepository` and `MediaFileContext` classes. The methods are currently stubbed out with TODO comments.

## MediaRepository.cs

In the `MediaRepository` class, you need to implement the `FindMedia` method. This method should find and return a media item based on its type and title.

### Instructions

1. Loop through each media item in the `_context.Media` list.
2. For each media item, check if its type matches the 'type' parameter (case-insensitive) and its title matches the 'title' parameter (case-insensitive).
3. If a match is found, return the media item.
4. If no match is found after checking all media items, return null.

## MediaFileContext.cs

In the `MediaFileContext` class, you need to implement the `SaveDataToFile` method. This method should save the current state of the `Media` list to a CSV file.

### Instructions

1. Loop through each media item in the 'media' list.
2. For each media item, convert its properties to a string format suitable for a CSV file.
    - For example, if a media item has properties 'Type', 'Id', and 'Title', the string might look like "Movie,1,Toy Story".
    - Note: You'll need to handle the 'Writers', 'Regions', and 'Genres' properties differently because they are arrays. You can join the elements of these arrays into a string with elements separated by a pipe character ('|').
3. Write these strings to the CSV file. Each string should be on a new line.
4. Make sure to include a header line at the top of the file with the names of the properties.

Good luck!
