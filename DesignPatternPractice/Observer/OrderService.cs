namespace DesignPatternPractice.Observer;

public class OrderService : ITicketChangeNotifier
{
    public void CompleteTask(int amount, int OrderId)
    {
        Console.WriteLine($"Order {OrderId} completed with amount {amount} is complete.");
        Notify(new TicketChange(OrderId, amount));
    }
}