namespace DesignPatternPractice.VisitorDesignPattern;

public interface Vistor
{
    void Visit(ConcreteElement1 element);
    void Visit(ConcreteElement2 element);
}