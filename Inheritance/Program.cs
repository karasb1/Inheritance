namespace Inheritance;

public class Device
{
    public string name;
    public string brand;
    public int price;
    public void Show()
    {
        Console.WriteLine($"Name: {name}");
    }
}
public class Car : Device
{
    public string color;
    public int speed;

    public void Sound()
    {
        Console.WriteLine("Vroom Vroom");
    }
    public void Show()
    {
        Console.WriteLine($"Name: {name}");
    }
    public void Desc()
    {
        Console.WriteLine($"Color: {color}");
        Console.WriteLine($"Speed: {speed}");
    }
}
public class Microwave : Device
{
    public string color;
    public int wattage;
    public void Sound()
    {
        Console.WriteLine("Zzzzzzz");
    }
    public void Show()
    {
        Console.WriteLine($"Name: {name}");
    }
    public void Desc()
    {
        Console.WriteLine($"Color: {color}");
        Console.WriteLine($"Wattage: {wattage}");
    }
}
public class Kettle : Device
{
    public string color;
    public int wattage;
    public int amount;
    public void Sound()
    {
        Console.WriteLine("Boiling");
    }
    public void Show()
    {
        Console.WriteLine($"Name: {name}");
    }
    public void Desc()
    {
        Console.WriteLine($"Color: {color}");
        Console.WriteLine($"Wattage: {wattage}");
        Console.WriteLine($"Amount: {amount}");
    }
}
public class Ship : Device
{
    public string color;
    public int speed;
    public void Sound()
    {
        Console.WriteLine("Toot Toot");
    }
    public void Show()
    {
        Console.WriteLine($"Name: {name}");
    }
    public void Desc()
    {
        Console.WriteLine($"Color: {color}");
        Console.WriteLine($"Speed: {speed}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Car car = new Car{name = "Car", brand = "Toyota", price = 20000, color = "Red", speed = 120};
        Microwave microwave = new Microwave{name = "Microwave", brand = "LG", price = 300, color = "Black", wattage = 800};
        Kettle kettle = new Kettle{name = "Kettle", brand = "Philips", price = 50, color = "White", wattage = 1500, amount = 1};
        Ship ship = new Ship{name = "Ship", brand = "Titanic", price = 1000000, color = "Blue", speed = 30};
        
        car.Show();
        car.Desc();
        car.Sound();
        Console.WriteLine();
        
        microwave.Show();
        microwave.Desc();
        microwave.Sound();
        Console.WriteLine();
        
        kettle.Show();
        kettle.Desc();
        kettle.Sound();
        Console.WriteLine();
        
        ship.Show();
        ship.Desc();
        ship.Sound();
    }
}