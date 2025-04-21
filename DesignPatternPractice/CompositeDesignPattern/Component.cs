namespace DesignPatternPractice.CompositeDesignPattern;

public interface Component
{
    void Move();
}
public class Shape : Component
{
    public void Move()
    {
        Console.WriteLine("shape moved");
    }
}
public class Group : Component
{
    private List<Component> Components = new List<Component>();

    public void AddComponent(Component component)
    {
        Components.Add(component);
    }
    public void Move()
    {
        Components.ForEach(component => component.Move());
    }
    
}