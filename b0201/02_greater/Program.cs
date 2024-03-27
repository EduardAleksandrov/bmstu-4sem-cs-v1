using System;

/*
    .env
    export HELLO=554hi
    $source .env
    $echo $HELLO
    $dotnet run
*/
    
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
            
            string? str= System.Environment.GetEnvironmentVariable("HELLO");
            Console.WriteLine(str);

            int obji = 5;
            Console.WriteLine(obji.ToString()); //объект в стеке
            Object obj2 = obji;
            Console.WriteLine(obj2.ToString()); //объект в куче

            IMovable tom = new Person();
            Car tesla = new Car(); // аналогично для IMovable tesla = new Car();
            tom.Move();     // Walking
            tesla.Move();   // Driving
        }
        
    }

    public static void Values(double? v)
    {
        if(v == null) Console.WriteLine(v);
        else Console.WriteLine(v.Value);
    }
}

interface IMovable
{
    void Move() => Console.WriteLine("Walking");
}
class Person : IMovable { }
class Car : IMovable
{
    public void Move() => Console.WriteLine("Driving");
}

