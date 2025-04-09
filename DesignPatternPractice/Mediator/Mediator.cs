namespace DesignPatternPractice.Mediator;

public interface Mediator
{
    void Notify(Colleage sender,string @event);
}