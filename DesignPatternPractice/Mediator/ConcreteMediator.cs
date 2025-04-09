namespace DesignPatternPractice.Mediator;

public class ConcreteMediator : Mediator
{
    private readonly Colleague1 _colleague1;
    private readonly Colleague2 _colleague2;

    public ConcreteMediator(Colleague2 colleague2, Colleague1 colleague1)
    {
       
        _colleague2 = colleague2;
        _colleague1 = colleague1;
        _colleague2.SetMediator(this);
        _colleague1.SetMediator(this);
    }

    public void Notify(Colleague sender, string @event)
    {
        Console.WriteLine($"ConcreteMediator  Notified by : {sender.GetType().Name}");
        if (sender is Colleague1)
        {
            
        }else if (sender is Colleague2)
        {
            
        }
    }
}