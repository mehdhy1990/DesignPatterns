namespace DesignPatternPractice.DecoratorPattern;

public class CompressData : IStream
{
    private IStream _stream;

    public CompressData(IStream stream)
    {
        _stream = stream;
    }

    public void Write(string data)
    {
        var compressed = Compress(data);
        _stream.Write(compressed);
    }

    public string Compress(string data)
    {
        return $"{data} is compressed";
    }
}