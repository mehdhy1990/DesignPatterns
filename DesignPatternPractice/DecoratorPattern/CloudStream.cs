namespace DesignPatternPractice.DecoratorPattern;

public class CloudStream : IStream
{
    public void Write(string data)
    {
        Console.WriteLine($"Cloud stream Writes: {data}");
    }
}