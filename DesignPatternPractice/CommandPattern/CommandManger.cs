namespace DesignPatternPractice.CommandPattern;

public class CommandManger {
    private Stack<ICommand> _commandStack;

    public void Invoke(ICommand command)
    {
        command.Execute();
        _commandStack.Push(command);
    }

    public void Undo()
    {
        _commandStack.Pop().Undo();
    }
}