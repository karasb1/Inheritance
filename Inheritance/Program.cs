namespace Inheritance;

public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
public class Tiger : Animal
{
    public string Color { get; set; }
    public override void Speak()
    {
        Console.WriteLine("Tiger roars");
    }
    public void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Color: {Color}");
    }
}
public class Crocodile : Animal
{
    public string Habitat { get; set; }
    public override void Speak()
    {
        Console.WriteLine("Crocodile growls");
    }
    public void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Habitat: {Habitat}");
    }
}
public class Kangaroo : Animal
{
    public string JumpHeight { get; set; }
    public override void Speak()
    {
        Console.WriteLine("Kangaroo grunts");
    }
    public void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Jump Height: {JumpHeight}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal tiger = new Tiger { Name = "Tiger", Age = 5, Color = "Orange" };
        Animal crocodile = new Crocodile { Name = "Crocodile", Age = 10, Habitat = "Swamp" };
        Animal kangaroo = new Kangaroo { Name = "Kangaroo", Age = 3, JumpHeight = "2 meters" };
        tiger.ShowInfo();
        tiger.Speak();
        Console.WriteLine();
        crocodile.ShowInfo();
        crocodile.Speak();
        Console.WriteLine();
        kangaroo.ShowInfo();
        kangaroo.Speak();
    }
}