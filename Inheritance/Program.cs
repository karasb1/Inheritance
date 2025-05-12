namespace Inheritance;

public abstract class Worker
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Position { get; set; }

    public Worker(string name, int age, string position)
    {
        Name = name;
        Age = age;
        Position = position;
    }
    public abstract void Print();
}

public class President : Worker
{
    public President(string name, int age, string position) : base(name, age, position)
    {
    }
    public override void Print()
    {
        Console.WriteLine($"President: {Name}, Age: {Age}, Position: {Position}");
    }
}

public class Security : Worker
{
    public Security(string name, int age, string position) : base(name, age, position)
    {
    }
    public override void Print()
    {
        Console.WriteLine($"Security: {Name}, Age: {Age}, Position: {Position}");
    }
}
public class Manager : Worker
{
    public Manager(string name, int age, string position) : base(name, age, position)
    {
    }
    public override void Print()
    {
        Console.WriteLine($"Manager: {Name}, Age: {Age}, Position: {Position}");
    }
}
public class Engineer : Worker
{
    public Engineer(string name, int age, string position) : base(name, age, position)
    {
    }
    public override void Print()
    {
        Console.WriteLine($"Engineer: {Name}, Age: {Age}, Position: {Position}");
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        President president = new President("John Doe", 50, "President");
        Security security = new Security("Jane Smith", 35, "Security");
        Manager manager = new Manager("Alice Johnson", 40, "Manager");
        Engineer engineer = new Engineer("Bob Brown", 30, "Engineer");
        
        president.Print();
        security.Print();
        manager.Print();
        engineer.Print();
    }
}