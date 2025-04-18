// See https://aka.ms/new-console-template for more information

using System.Text;
using DesignPatternPractice.CommandPattern;
using DesignPatternPractice.Strategy;

Employee employee = new Employee(6,"Mehdi");
CommandManger commandManger = new ();
IEmployeeRepo employeeRepo = new EmployeeRepo();
commandManger.Invoke(new AddEmployee(employeeRepo,employee));
employeeRepo.WriteToConsole();
commandManger.Undo();
employeeRepo.WriteToConsole();