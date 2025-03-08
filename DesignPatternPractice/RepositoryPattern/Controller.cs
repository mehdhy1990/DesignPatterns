namespace DesignPatternPractice.RepositoryPattern;

public class Controller
{
    public IRepository Repository;

    public Controller(IRepository repository)
    {
        this.Repository = repository;
    }
    public void PrintData()
    {
        Console.WriteLine(Repository.GetData());
    }
}