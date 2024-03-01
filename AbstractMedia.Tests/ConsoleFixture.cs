namespace AbstractMedia.Tests;

public class ConsoleFixture : IDisposable
{
    private readonly TextReader _originalIn;
    private readonly TextWriter _originalOut;

    public ConsoleFixture()
    {
        _originalIn = Console.In;
        _originalOut = Console.Out;
    }

    public void Dispose()
    {
        Console.SetIn(_originalIn);
        Console.SetOut(_originalOut);
    }
}
