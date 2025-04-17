namespace DesignPatternPractice.Strategy;

public class XMLExportService : IExportService
{
    public void Export(Order order)
    {
        Console.WriteLine("Exporting XML file");
    }
}