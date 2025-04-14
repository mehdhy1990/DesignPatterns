namespace DesignPatternPractice.Mediator;

public class Lawyer : TeamMember
{
    public Lawyer(string name) : base(name)
    {
    }

    public override void ReceiveMessage(string from, string message)
    {
        Console.WriteLine($"message received by {Name}");
        base.ReceiveMessage(from, message);
    }
}