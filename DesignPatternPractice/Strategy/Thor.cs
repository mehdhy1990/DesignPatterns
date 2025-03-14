namespace DesignPatternPractice.Strategy;

public class Thor : IEenemy
{
    public void Attack()
    {
        Console.WriteLine("Thor is attacking");
    }
}