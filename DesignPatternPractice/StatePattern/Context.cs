namespace DesignPatternPractice.StatePattern;

public class Context
{
    private State _state;

    public void SetState(State state)
    {
        _state = state;
    }
}