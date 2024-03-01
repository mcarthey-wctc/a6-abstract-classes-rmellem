using Moq;
using AbstractMedia.Core.Models;
using AbstractMedia.Core.Context;
using Xunit;
using System.Collections.Generic;

namespace AbstractMedia.Tests;

public class MediaRepositoryTests
{
    [Fact]
    public void FindMedia_MediaExists_ReturnedSuccessfully()
    {
        // Arrange
        var mockContext = new Mock<IMediaContext>();
        var mediaRepository = new MediaRepository(mockContext.Object);
        var media = new Movie(1, "Test Movie", new[] { "Action", "Adventure" });

        mockContext.Setup(context => context.Media).Returns(new List<Media> { media });

        // Act
        var result = mediaRepository.FindMedia("Movie", "Test Movie");

        // Assert
        Assert.Equal(media, result);
    }
}
