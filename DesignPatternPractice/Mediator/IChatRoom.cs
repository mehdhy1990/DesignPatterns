namespace DesignPatternPractice.Mediator;

public interface IChatRoom
{
    public void Register(TeamMember teamMember);

    public void SendMessage(string from, string message);
}