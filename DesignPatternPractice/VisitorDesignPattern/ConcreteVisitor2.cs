namespace DesignPatternPractice.VisitorDesignPattern;

public class ConcreteVisitor2 : Vistor
{
    public void Visit(ConcreteElement1 element)
    {
        throw new NotImplementedException();
    }

    public void Visit(ConcreteElement2 element)
    {
        throw new NotImplementedException();
    }
}