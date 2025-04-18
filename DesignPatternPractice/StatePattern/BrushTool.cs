namespace DesignPatternPractice.StatePattern;

public class BrushTool : Tool
{
    public void MouseDown()
    {
        Console.WriteLine("Brush icon selected ");
    }

    public void MouseUp()
    {
        Console.WriteLine("Brushing is begun");
    }
}