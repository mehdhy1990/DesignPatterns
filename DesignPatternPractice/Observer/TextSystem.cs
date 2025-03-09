namespace DesignPatternPractice.Observer;

public class TextSystem : IMessageObserver
{
    private readonly MessageSystem _messageSystem;

    public TextSystem(MessageSystem messageSystem)
    {
        _messageSystem = messageSystem;
       
    }

    public void Update()
    {
        var state = _messageSystem.GetState();
        Console.WriteLine($"the text system is reacted to {state}");
    }
}