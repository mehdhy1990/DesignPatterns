namespace DesignPatternPractice.Mediator;

public interface IChatRoom
{
    public void Register(TeamMember member);
    public void SendMessage(string message);
}

public class TeamMember
{
    public IChatRoom? ChatRoom;

    public string Name;

    public TeamMember(string name)
    {
        Name = name;
    }

    internal void SetTeamMember(IChatRoom chatRoom)
    {
        ChatRoom = chatRoom;
    }

    
}