namespace DesignPatternPractice.Observer;

public class MessageSystem : IMessageSystem
{
    private readonly List<IMessageObserver> _observers = [];
    private string _textMessage = string.Empty;
    private string _videoMessage = string.Empty;

    public void SetState(string message,string video)
    {
            _textMessage = message;    
            _videoMessage = video;
            Notify();
    }

    public string GetVideoMessage()
    {
        return _videoMessage;
    }
    public string GetMessage()
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

    public void Notify()
    {
        foreach (var item in _observers)
        {
            item.Update();
        }
    }
}