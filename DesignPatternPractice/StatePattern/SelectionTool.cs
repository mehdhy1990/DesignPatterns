namespace DesignPatternPractice.StatePattern;

public class SelectionTool : Tool
{
    public void MouseDown()
    {
        Console.WriteLine("select and icon ");
    }

    public void MouseUp()
    {
        Console.WriteLine("draw an Icon with selection tool ");
    }
}