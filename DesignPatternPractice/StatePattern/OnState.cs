namespace DesignPatternPractice.StatePattern;

public class OnState : IState
{
    public void Power(Context context)
    {
        Console.WriteLine("the phone should have shut down");
        context.SetState(new OffState());
    }
}