namespace Inheritance;

public class Human
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    
    public void ShowInfo()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}, Age: {Age}");
    }
}
public class Builder : Human
{
    public string Company { get; set; }
    public int Experience { get; set; }
    
    public void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Company: {Company}, Experience: {Experience} years");
    }
    public void BuildCompany()
    {
        Console.WriteLine("Building a company...");
    }
}
public class Sailor : Human
{
    public string ShipName { get; set; }
    public int YearsAtSea { get; set; }
    
    public void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Ship: {ShipName}, Years at Sea: {YearsAtSea}");
    }
    public void Sail()
    {
        Console.WriteLine("Sailing the seas...");
    }
}
public class Pilot : Human
{
    public string Airline { get; set; }
    public int FlightHours { get; set; }
    
    public void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Airline: {Airline}, Flight Hours: {FlightHours}");
    }
    public void Fly()
    {
        Console.WriteLine("Flying the plane...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Human human = new Human
        {
            FirstName = "John",
            LastName = "Doe",
            Age = 30
        };
        Console.WriteLine("Human Info:");
        human.ShowInfo();
        
        Builder builder = new Builder
        {
            FirstName = "Alice",
            LastName = "Smith",
            Age = 28,
            Company = "Tech Corp",
            Experience = 5
        };
        Console.WriteLine();
        Console.WriteLine("Builder Info:");
        builder.ShowInfo();
        builder.BuildCompany();
        
        Sailor sailor = new Sailor
        {
            FirstName = "Bob",
            LastName = "Johnson",
            Age = 35,
            ShipName = "Sea Explorer",
            YearsAtSea = 10
        };
        Console.WriteLine();
        Console.WriteLine("Sailor Info:");
        sailor.ShowInfo();
        sailor.Sail();
        
        Pilot pilot = new Pilot
        {
            FirstName = "Charlie",
            LastName = "Brown",
            Age = 40,
            Airline = "Sky Airlines",
            FlightHours = 2000
        };
        Console.WriteLine();
        Console.WriteLine("Pilot Info:");
        pilot.ShowInfo();
        pilot.Fly();
        
        Console.WriteLine("Press any key to exit...");
    }
}