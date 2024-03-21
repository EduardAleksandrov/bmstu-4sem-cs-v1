namespace Reflection;

public class Employee
{
    [EmpAttribute("Fullname")]
    public string? Name {get; set;}

    public int Age {get; set;}

    public string? Position {get; set;}

    public Employee? Manager {get; set;}

}
