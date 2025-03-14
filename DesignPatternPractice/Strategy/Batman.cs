namespace DesignPatternPractice.Strategy;

public class Batman : IEenemy
{
    public void Attack()
    {
        Console.WriteLine("hello from Batman!");
    }
}