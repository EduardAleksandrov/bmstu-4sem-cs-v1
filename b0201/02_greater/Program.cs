using System;
    
internal class Program
{
    private static void Main(string[] args)
    {
        for(;;)
        {
            string? name = Console.ReadLine();
            Console.WriteLine($"Hello, World! {name}");
            
            St.ClassMsg mc = new St.ClassMsg();
            mc.Hi();
            mc.Convert();

            double? x = 5;
            Values(x);

            double i = (double) Math.Sqrt(16.5);
            Console.WriteLine(i.GetType() == typeof(double));
        }
        
    }

    public static void Values(double? v)
    {
        if(v == null) Console.WriteLine(v);
        else Console.WriteLine(v.Value);
    }
}

