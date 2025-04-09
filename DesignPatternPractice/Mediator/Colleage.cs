namespace DesignPatternPractice.Mediator;

public class Colleage
{
    protected Mediator _mediator = null!;


    void SetMediator(Mediator mediator)
    {
        _mediator = mediator;
    }
}