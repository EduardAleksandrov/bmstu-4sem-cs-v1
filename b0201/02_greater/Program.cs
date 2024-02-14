using System;
    

internal class Program
{
    private static void Main(string[] args)
    {
        string? name = Console.ReadLine();
        Console.WriteLine($"Hello, World! {name}");
        
        St.ClassMsg mc = new St.ClassMsg();
        mc.Hi();

        double? x = 5;
        Values(x);
    }

    public static void Values(double? v)
    {
        Console.WriteLine(v.Value);
    }
}

