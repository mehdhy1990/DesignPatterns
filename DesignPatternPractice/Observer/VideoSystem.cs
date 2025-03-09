namespace DesignPatternPractice.Observer;

public class VideoSystem : IMessageObserver
{
    private readonly MessageSystem _messageSystem;

    public VideoSystem(MessageSystem messageSystem)
    {
        _messageSystem = messageSystem;
    }
    public void Update()
    {
        var vid = _messageSystem.GetVideoMessage();
        if (vid != "")
        {
            Console.WriteLine($"Video system is reacting: {vid}");
        }
       
    }
}