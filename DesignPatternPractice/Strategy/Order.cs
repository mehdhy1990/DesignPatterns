using System.Reflection.Metadata;

namespace DesignPatternPractice.Strategy;

public class Order
{
    public string Name { get; set; }
    public int OrderId { get; set; }
    public int Amount { get; set; }
    
    public IExportService? ExportService { get; set; }

    public Order(string name, int orderId, int amount)
    {
        Name = name;
        OrderId = orderId;
        Amount = amount;
      
    }

    public void Export()
    {
        Console.WriteLine($"Order id is: {OrderId}: with name of {Name} ,and with the amount of {Amount} ");
        ExportService.Export(this);
    }
}