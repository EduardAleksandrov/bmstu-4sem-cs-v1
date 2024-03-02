using Newtonsoft.Json;

namespace St
{
    public class ClassMsg
    {
        public void Hi() 
        {
            Console.WriteLine("Hello, from ClassMsg!");
        }
        public void Convert()
        {
            Person tom = new Person("Tom", 38);
            string json = JsonConvert.SerializeObject(tom);
            Person? result = JsonConvert.DeserializeObject<Person>(json);
            Console.WriteLine(json);
            if(result != null) Console.WriteLine(result.Name);
            
        }
    }

    public class Person
    {
        public string Name {get;set;}
        public int Age {get;set;}
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
