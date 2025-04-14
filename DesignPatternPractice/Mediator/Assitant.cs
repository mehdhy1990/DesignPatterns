namespace DesignPatternPractice.Mediator;

public class Assitant : TeamMember
{
    public Assitant(string name) : base(name)
    {
    }
    public override void ReceiveMessage(string from, string message)
    {
        Console.WriteLine($"the {nameof(this.Name)} with name of {Name} is received");
        base.ReceiveMessage(from, message);
    }
}