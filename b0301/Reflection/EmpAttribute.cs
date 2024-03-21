namespace Reflection;

public class EmpAttribute: Attribute
{
    public EmpAttribute(string name)
    {
        Name = name;
    }
    public string Name {get;}
}
