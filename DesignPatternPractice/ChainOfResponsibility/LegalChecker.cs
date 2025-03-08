namespace DesignPatternPractice.ChainOfResponsibility;

public abstract class LegalChecker
{
    protected LegalChecker? NextChecker = null;

    public void SetNextChecker(LegalChecker nextChecker)
    {
        NextChecker = nextChecker;
    }

    public abstract bool Check();

}