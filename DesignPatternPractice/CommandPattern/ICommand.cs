namespace DesignPatternPractice.CommandPattern;

public interface ICommand
{
    public void Execute();
    public void Undo();
}