namespace DesignPatternPractice.AdapterDesignPattern;

public class Image
{
    
}

public interface Fiter
{
    void Apply(Image image);
}
public class VividFiler : Fiter
{
    public void Apply(Image image)
    {
        Console.WriteLine("Applying image filter");
    }
}

public class ImageView
{
    private Image _image;

    public ImageView(Image image)
    {
        _image = image;
    }

    public void Apply(Fiter filter)
    {
        filter.Apply(_image);
    }
}
public class CamelFilter : Fiter
{
    private Camel _camel;

    public CamelFilter(Camel camel)
    {
        _camel = camel;
    }

    public void Apply(Image image)
    {
      _camel.intialize();
      _camel.Render(image);
    }
}