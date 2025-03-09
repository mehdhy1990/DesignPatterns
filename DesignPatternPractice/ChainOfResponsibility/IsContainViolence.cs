namespace DesignPatternPractice.ChainOfResponsibility;

public class IsContainViolence : LegalChecker
{
    public override bool Check(Email email)
    {
        if(email.Body.Contains("blood") || email.Title.Contains("blood")) return true;
        if( NextChecker is null ) return false;
        return NextChecker.Check(email);
    }
}