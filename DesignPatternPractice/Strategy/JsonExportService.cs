namespace DesignPatternPractice.Strategy;

public class JsonExportService : IExportService
{
    public void Export(Order order)
    {
        Console.WriteLine("Exporting JSON file");
    }
}