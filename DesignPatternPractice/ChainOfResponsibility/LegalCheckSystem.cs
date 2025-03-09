namespace DesignPatternPractice.ChainOfResponsibility;

public class LegalCheckSystem
{
    private readonly LegalChecker _chain;

    public LegalCheckSystem()
    {
        _chain = new IsContainDrug();
        var pornChecker = new IsContainPornography();
        var violenceChecker = new IsContainViolence();
        _chain.SetNextChecker(pornChecker);
        pornChecker.SetNextChecker(violenceChecker);
    }

    public bool Check(Email email)
    {
        return _chain.Check(email);
    }
}