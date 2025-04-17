namespace DesignPatternPractice.Observer;

public interface ITicketChangeListener
{
    public void ReceiveTicketChange(TicketChange ticketChange);
}