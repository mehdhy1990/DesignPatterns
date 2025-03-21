namespace DesignPatternPractice.VisitorDesignPattern;

public class ConcreteElement2 : Element
{
    public void Accept(Vistor visitor)
    {
       visitor.Visit(this);
    }

    public string Operation()
    {
        return "ConcreteElement2";
    }
}