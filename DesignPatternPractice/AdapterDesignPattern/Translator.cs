using System.Threading.Channels;

namespace DesignPatternPractice.AdapterDesignPattern;

public class Translator
{
    public void TranslateLanguage()
    {
        Console.WriteLine("Hello from TranslateLanguage");
    }
}

public class CzechLanguage()
{
    public void Speak()
    {
        Console.WriteLine("Hello from CzechLanguage");
    }
}