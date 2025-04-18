namespace DesignPatternPractice.CommandPattern;

public class AddEmployee : ICommand
{
    private readonly IEmployeeRepo _employeeRepo;
    private readonly Employee _employee;


    public AddEmployee(IEmployeeRepo employeeRepo, Employee employee)
    {
        _employeeRepo = employeeRepo;
        _employee = employee;
    }

    public void Execute()
    {
        _employeeRepo.AddEmployee(_employee);
    }

    public void Undo()
    {
        _employeeRepo.RemoveEmployee(_employee);
    }
}