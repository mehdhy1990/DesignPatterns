namespace DesignPatternPractice.Observer;

public class SpreadSheet : IObserver
{
    public void Update()
    {
        Console.WriteLine("SpreadSheet is updating...");
    }
}