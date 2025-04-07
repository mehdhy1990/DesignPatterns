namespace DesignPatternPractice.TemplateFactory;

public class ConcreteClass1 : AbstractClass
{
    public override void PrimitiveOperation1()
    {
        Console.WriteLine("PrimitiveOperation1 called   ");
    }

    public override void PrimitiveOperation2()
    {
        Console.WriteLine("PrimitiveOperation2 called   ");
    }
}