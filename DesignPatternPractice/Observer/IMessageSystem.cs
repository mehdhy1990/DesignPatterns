namespace DesignPatternPractice.Observer;

public interface IMessageSystem
{
    void Attach(IMessageObserver observer);
    void Detach(IMessageObserver observer);
    void Notify(IMessageObserver observer);
}