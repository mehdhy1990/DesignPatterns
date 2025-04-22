namespace DesignPatternPractice.DecoratorPattern;

public class EncryptData : IStream
{
    private IStream _stream;

    public EncryptData(IStream stream)
    {
        _stream = stream;
    }


    public void Write(string data)
    {
        var encrypted = Encrypted(data);
        _stream.Write(encrypted);
    }

    public string Encrypted(string data)
    {
        return "@#$%**#)@";
    }
}