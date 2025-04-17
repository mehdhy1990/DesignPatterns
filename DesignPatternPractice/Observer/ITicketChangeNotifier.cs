namespace DesignPatternPractice.Observer;

public abstract class ITicketChangeNotifier
{
    public List<ITicketChangeListener> observers = new();

    public void AddObserver(ITicketChangeListener listener)
    {
        this.observers.Add(listener);
    }

    public void RemoveObserver(ITicketChangeListener listener)
    {
        this.observers.Remove(listener);
    }

    public void Notify(TicketChange ticketChange)
    {
        foreach (var item in observers)
        {
            item.ReceiveTicketChange(ticketChange);
        }
    }
    
}