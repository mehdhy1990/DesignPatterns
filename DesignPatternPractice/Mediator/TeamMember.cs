namespace DesignPatternPractice.Mediator;

public class TeamMember
{
    public IChatRoom? ChatRoom;
    public string Name;

    public TeamMember(string name)
    {
        Name = name;
    }

    internal void SetChatRoom(IChatRoom chatRoom)
    {
        ChatRoom = chatRoom;
    }

    public void SendMessage(string Message)
    {
        ChatRoom?.SendMessage(Name, Message);
    }

    public virtual void ReceiveMessage(string from,string message)
    {
        Console.WriteLine($"received {from} to {Name}: {message}");
    }
}