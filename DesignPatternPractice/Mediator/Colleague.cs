namespace DesignPatternPractice.Mediator;

public class Colleague
{
    protected Mediator _mediator = null!;


  public  void SetMediator(Mediator mediator)
    {
        _mediator = mediator;
    }
}