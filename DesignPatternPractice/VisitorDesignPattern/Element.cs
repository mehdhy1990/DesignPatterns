namespace DesignPatternPractice.VisitorDesignPattern;

public interface Element
{
    void Accept(Vistor visitor);
}

public interface Vistor
{
    void Visit(ConcreteElement1 element);
    void Visit(ConcreteElement2 element);
}