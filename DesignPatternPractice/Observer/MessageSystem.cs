namespace DesignPatternPractice.Observer;

public class MessageSystem : IMessageSystem
{
    private readonly List<IMessageObserver> _observers = [];
    private string _textMessage = string.Empty;

    public void SetState(string message)
    {
            _textMessage = message;        
    }

    public string GetState()
    {
        return _textMessage;
    }
    public void Attach(IMessageObserver observer)
    {
       _observers.Add(observer);
    }

    public void Detach(IMessageObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify(IMessageObserver observer)
    {
        foreach (var item in _observers)
        {
            item.Update();
        }
    }
}