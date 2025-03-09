namespace DesignPatternPractice.FactoryMethodPattern;

public class BMW : CarFactory
{
    public override ICar CreateCar()
    {
        var car = new X6();
        car.Print();
        return car;
    }
}