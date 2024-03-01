namespace AbstractMedia.Tests;

[CollectionDefinition("Console collection")]
public class ConsoleCollection : ICollectionFixture<ConsoleFixture>
{
    // This class has no code, and is never created. Its purpose is simply
    // to be the place to apply [CollectionDefinition] and all the
    // ICollectionFixture<> interfaces.
}
