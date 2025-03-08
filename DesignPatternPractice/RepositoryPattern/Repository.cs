namespace DesignPatternPractice.RepositoryPattern;

public class Repository : IRepository
{
    public string GetData()
    {
        return "Hello World!";
    }

    public void SaveData(string data)
    {
        Console.WriteLine("data saved to database");
    }
}