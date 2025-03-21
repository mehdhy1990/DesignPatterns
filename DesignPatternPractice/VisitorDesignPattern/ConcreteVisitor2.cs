namespace DesignPatternPractice.VisitorDesignPattern;

public class ConcreteVisitor2 : Vistor
{
    public void Visit(ConcreteElement1 element)
    {
        var message = element.Operation();
        Console.WriteLine($"ConcreteVisitor2: {message}");
    }

    public void Visit(ConcreteElement2 element)
    {
        var message = element.Operation();
        Console.WriteLine($"ConcreteVisitor2: {message}");
    }
}