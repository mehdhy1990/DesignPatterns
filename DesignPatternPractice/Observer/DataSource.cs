namespace DesignPatternPractice.Observer;

public class DataSource : IDataSource
{
    private List<IObserver> _observers = new List<IObserver>();
    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        if (_observers.Any()) _observers.ForEach(o => o.Update());
            
        
    }
}