namespace DesignPatternPractice.Observer;

public class EmailObserver : IMessageObserver
{
    private readonly MessageSystem _email;
    public EmailObserver(MessageSystem messageSystem)
    {
        _email = messageSystem;
    }
    public void Update()
    {
        var email = _email.GetMessage();
        if (email != "")
        {
            Console.WriteLine($"email reaction to : {email}");
        }
        
    }
}