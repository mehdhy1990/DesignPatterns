namespace DesignPatternPractice.Observer;

public class TicketChange
{
    public int Amount { get; set; }
    public int TicketId { get; set; }

    public TicketChange(int amount, int ticketId)
    {
        Amount = amount;
        TicketId = ticketId;
    }
}

public class OrderServevic : TicketChange
{
    public OrderServevic(int amount, int ticketId) : base(amount, ticketId)
    {
    }
} 