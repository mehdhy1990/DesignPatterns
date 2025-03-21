namespace DesignPatternPractice.VisitorDesignPattern;

public class ConcreteElement1 : Element
{
    public void Accept(Vistor visitor)
    {
        throw new NotImplementedException();
    }

    public string Operation()
    {
        return "ConcreteElement1";
    }
}