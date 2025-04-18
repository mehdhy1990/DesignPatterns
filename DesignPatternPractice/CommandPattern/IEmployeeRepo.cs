namespace DesignPatternPractice.CommandPattern;

public interface IEmployeeRepo
{
    public void AddEmployee(Employee employee);
    public void RemoveEmployee(Employee employee);
    public bool HasEmployee(int employeeId);
    public void WriteToConsole(); 
}