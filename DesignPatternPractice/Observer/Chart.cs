namespace DesignPatternPractice.Observer;

public class Chart : IObserver
{
    public void Update()
    {
        Console.WriteLine("Chart is updating...");
    }
}