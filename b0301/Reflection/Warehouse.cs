namespace Reflection;

public class Warehouse
{
    private string name = "Undefined";
 
    public string Name
    {
        get
        {
            return name;    // возвращаем значение свойства
        }
        set
        {
            name = value;   // устанавливаем новое значение свойства
        }
    }
}
