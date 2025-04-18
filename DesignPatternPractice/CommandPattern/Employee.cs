using System.Threading.Channels;

namespace DesignPatternPractice.CommandPattern;

public class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }

    public Employee(int employeeId, string name)
    {
        EmployeeId = employeeId;
        Name = name;
    }
}