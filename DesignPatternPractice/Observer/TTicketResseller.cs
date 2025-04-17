using System.Runtime.CompilerServices;

namespace DesignPatternPractice.Observer;

public class TTicketResseller :   ITicketChangeListener
{
    
    public void ReceiveTicketChange(TicketChange ticketChange)
    {
        Console.WriteLine($"the {GetType().Name} receives the ticket id : {ticketChange.TicketId}" +
                          $" with amount of: {ticketChange.Amount}");
        
    }
}