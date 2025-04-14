namespace DesignPatternPractice.Mediator;

public class ChatRoom : IChatRoom
{
    public Dictionary<string, TeamMember> Members = new();

  
    public void Register(TeamMember member)
    {
        if (!Members.ContainsKey(member.Name))
        {
            Members.Add(member.Name, member);
        }
    }

    public void SendMessage(string from, string message)
    {
        foreach (var member in Members.Values)
        {
            member.ReceiveMessage(from, message);
        }
    }
}