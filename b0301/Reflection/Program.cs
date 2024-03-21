using System.Reflection;

using Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Type employeeType = typeof(Employee);

        ConstructorInfo? ctor = employeeType.GetConstructor([]);
        object? employee = ctor?.Invoke([]);

        PropertyInfo[] props = employeeType.GetProperties();

        foreach (var prop in props)
        {
            if(prop.Name == nameof(Employee.Name)) // nameof возвращает строку
            {
                prop.SetValue(employee, "Ivan");
            }
            var attr = prop.GetCustomAttribute<EmpAttribute>();
            Console.WriteLine(attr == null ? prop.Name : attr.Name);
        }

        Employee emp = new Employee();

        Console.WriteLine(emp.GetType().FullName); // второй способ после Type

        Console.WriteLine("Hello, World!");


    }
}