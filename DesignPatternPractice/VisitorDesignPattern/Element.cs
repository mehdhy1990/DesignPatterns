namespace DesignPatternPractice.VisitorDesignPattern;

public interface Element
{
    void Accept(Vistor visitor);
}