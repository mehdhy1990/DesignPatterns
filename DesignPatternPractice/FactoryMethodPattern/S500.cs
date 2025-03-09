using System.Runtime.CompilerServices;

namespace DesignPatternPractice.FactoryMethodPattern;

public class S500 : ICar
{
    public void Print()
    {
      
        Console.WriteLine($"the car name is {GetType().Name} ");
    }
}