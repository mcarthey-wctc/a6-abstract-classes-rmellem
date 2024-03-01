using Moq;
using AbstractMedia.Core.Models;
using AbstractMedia.Core.Services;
using AbstractMedia.Core.Context;
using Xunit;
using System;
using System.IO;

namespace AbstractMedia.Tests;

[Collection("Console collection")]
public class MediaServiceTests
{
    [Fact]
    public void FindMedia_MediaExists_ReturnedSuccessfully()
    {
        // Arrange
        var mockRepo = new Mock<IMediaRepository>();
        var mediaService = new MediaService(mockRepo.Object);
        var media = new Movie(1, "Test Movie", new[] { "Action", "Adventure" });

        mockRepo.Setup(repo => repo.FindMedia(It.IsAny<string>(), It.IsAny<string>())).Returns(media);

        // Redirect Console input/output
        var input = new StringReader("Movie\nTest Movie\n");
        Console.SetIn(input);

        var output = new StringWriter();
        Console.SetOut(output);

        // Act
        mediaService.FindMedia();

        // Assert
        mockRepo.Verify(repo => repo.FindMedia(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
    }
}
