namespace DesignPatternPractice.ChainOfResponsibility;

public class IsContainPornography : LegalChecker
{
    public override bool Check(Email email)
    {
        if (email.Body.Contains("porn") || email.Title.Contains("porn"))
        {
            Console.WriteLine("hello from porn checker");
            return true;
        }
        if(NextChecker is null) return false;
        return NextChecker.Check(email);
    }
}