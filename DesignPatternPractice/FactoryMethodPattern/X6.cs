namespace DesignPatternPractice.FactoryMethodPattern;

public class X6 : ICar
{
    public void Print()
    {
        Console.WriteLine($"the car name is {GetType().Name}");
    }
}