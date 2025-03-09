namespace DesignPatternPractice.ChainOfResponsibility;

public class IsContainDrug : LegalChecker
{
    public override bool Check(Email email)
    {
        if (email.Title.Contains("Drug") || email.Body.Contains("Drug"))
        {
            return true;
        }

        if (NextChecker is null)
        {
            return false;
        }
        return NextChecker.Check(email);
    }
}