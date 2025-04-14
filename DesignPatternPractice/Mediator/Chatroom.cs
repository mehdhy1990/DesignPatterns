namespace DesignPatternPractice.Mediator;

public class Chatroom : IChatRoom
{
    public Dictionary<string, TeamMember> Members = new();

    public void Register(TeamMember member)
    {
        if (!Members.ContainsKey(member.Name))
        {
            Members.Add(member.Name, member);
        }
    }

    public void SendMessage(TeamMember teamMember, string message)
    {
        throw new NotImplementedException();
    }

    

}