namespace DesignPatternPractice.StatePattern;

public class OffState : IState
{
    public void Power(Context context)
    {
        Console.WriteLine("the phone should have start off");
        context.SetState(new OnState());
    }
}