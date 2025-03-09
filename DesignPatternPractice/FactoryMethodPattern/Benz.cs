namespace DesignPatternPractice.FactoryMethodPattern;

public class Benz : CarFactory
{
    public override ICar CreateCar()
    {
        var car = new S500();
        car.Print();
        return car;
    }
}