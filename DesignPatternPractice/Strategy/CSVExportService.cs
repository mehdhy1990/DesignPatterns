namespace DesignPatternPractice.Strategy;

public class CSVExportService : IExportService
{
    public void Export(Order order)
    {
        Console.WriteLine("Exporting CSV file");
    }
}