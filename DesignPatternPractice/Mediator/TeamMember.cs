namespace DesignPatternPractice.Mediator;

public abstract class TeamMember
{
    public IChatRoom? ChatRoom;
    public string Name { get; set; }

    public TeamMember(string Name)
    {
        
    }
    public void SetChatRoom(IChatRoom chatRoom)
    {
        ChatRoom = chatRoom;
    }
    public void SendMesage(string message)
    {
        Console.WriteLine($"{this.GetType().Name}: {message}");
    }

    public virtual void ReceiveMesage()
    {
        Console.WriteLine($"{this.GetType().Name}: received the message");
    }
}