namespace DesignPatternPractice.Observer;

public class TicketStockService :   ITicketChangeListener
{
    
    public void ReceiveTicketChange(TicketChange ticketChange)
    {
        Console.WriteLine($"the {nameof(TicketStockService)} receives the ticket change: {ticketChange.TicketId}" +
                          $"with amount: {ticketChange.Amount}");
        
    }
}