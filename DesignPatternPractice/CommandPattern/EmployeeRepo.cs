namespace DesignPatternPractice.CommandPattern;

public class EmployeeRepo : IEmployeeRepo
{
    private readonly List<Employee> _employees = new ()
    {
        new (1,"John"),
        new (2,"Mary"),
        new (3,"Jane"),
    };
    public void AddEmployee(Employee employee)
    {
        _employees.Add(employee);
    }

    public void RemoveEmployee(Employee employee)
    {
        _employees.Remove(employee);
    }

    public bool HasEmployee(int employeeId)
    {
        return _employees.Any(e => e.EmployeeId == employeeId);
    }

    public void WriteToConsole()
    {
        _employees.ForEach(employee => Console.WriteLine($" Employee : {employee.Name} , Employee id: {employee.EmployeeId}"));
    }
}