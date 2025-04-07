namespace DesignPatternPractice.TemplateFactory;

public abstract class AbstractClass
{
    public void TemplateMethod()
    {
        Console.WriteLine("Before operation 1");
        PrimitiveOperation1();
        Console.WriteLine("Before operation 2");
        PrimitiveOperation2();
        Console.WriteLine("Before Hook");
        Hook();
    }
    public abstract void PrimitiveOperation1();
    public abstract void PrimitiveOperation2();

    public virtual void Hook()
    {
        Console.WriteLine("Hook");
    }
}