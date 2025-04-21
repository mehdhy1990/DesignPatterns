namespace DesignPatternPractice.Observer;

public interface IDataSource
{
   void AddObserver(IObserver observer);
   void RemoveObserver(IObserver observer);
   void NotifyObservers(); 
}