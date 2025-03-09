namespace DesignPatternPractice.ChainOfResponsibility;

public class LegalCheckSystem
{
    private readonly LegalChecker _chain;

    public LegalCheckSystem()
    {
        _chain = new IsContainDrug();
        var pornChecker = new IsContainPornography();
        var violenceChecker = new IsContainViolence();
        _chain.SetNextChecker(new IsContainPornography());
        pornChecker.SetNextChecker(new IsContainViolence());
    }

    public bool Check(Email email)
    {
        return _chain.Check(email);
    }
}