using System.Threading.Channels;

namespace DesignPatternPractice.AdapterDesignPattern;

public class Translator : ITranslator
{
    private readonly CzechLanguage _language;
    public Translator(CzechLanguage czechLanguage)
    {
        _language = czechLanguage;
    }
    public void Translate()
    {
      _language.Speak();
    }
}