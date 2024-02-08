using System;
    

internal class Program
{
    private static void Main(string[] args)
    {
        string? name = Console.ReadLine();
        Console.WriteLine($"Hello, World! {name}");
        
        ClassMsg mc = new ClassMsg();
        mc.Hi();
        

    }
}

