namespace DesignPatternPractice.Strategy;

public class Superman : IEenemy
{
    public void Attack()
    {
        Console.WriteLine("hello from superman");
    }
}