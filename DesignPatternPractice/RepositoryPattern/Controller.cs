namespace DesignPatternPractice.RepositoryPattern;

public class Controller
{
    public void PrintData()
    {
        var repo = new Repository();
        Console.WriteLine(repo.GetData());
    }
}