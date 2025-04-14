namespace DesignPatternPractice.Mediator;

public class TeamMember
{
    public string Name { get; set; }
    public void SendMesage(string message)
    {
        Console.WriteLine($"{this.GetType().Name}: {message}");
    }

    public virtual void ReceiveMesage()
    {
        Console.WriteLine($"{this.GetType().Name}: received the message");
    }
}