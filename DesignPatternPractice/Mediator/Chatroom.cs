namespace DesignPatternPractice.Mediator;

public class Chatroom
{
    public Dictionary<string, TeamMember> Members = new();

    public void Register(TeamMember member)
    {
        if (!Members.ContainsKey(member.Name))
        {
            Members.Add(member.Name, member);
        }
    }

    public void SendMessage(string message)
    {
        Console.WriteLine("Hello to all team members");
    }

}