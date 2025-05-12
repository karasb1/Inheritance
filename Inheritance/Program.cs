namespace Inheritance;

public abstract class Figure
{
    public abstract void Area();
}
public class Rectangle : Figure
{
    public int Width { get; set; }
    public int Height { get; set; }
    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }
    public override void Area()
    {
        Console.WriteLine($"Area of Rectangle is {Width * Height}");
    }
}
public class Circle : Figure
{
    public int Radius { get; set; }
    public Circle(int radius)
    {
        Radius = radius;
    }
    public override void Area()
    {
        Console.WriteLine($"Area of Circle is {Math.PI * Radius * Radius}");
    }
}
public class RightTriangle : Figure
{
    public int Base { get; set; }
    public int Height { get; set; }
    public RightTriangle(int baseLength, int height)
    {
        Base = baseLength;
        Height = height;
    }
    public override void Area()
    {
        Console.WriteLine($"Area of Right Triangle is {(Base * Height) / 2}");
    }
}
public class Trapezium : Figure
{
    public int Base1 { get; set; }
    public int Base2 { get; set; }
    public int Height { get; set; }
    public Trapezium(int base1, int base2, int height)
    {
        Base1 = base1;
        Base2 = base2;
        Height = height;
    }
    public override void Area()
    {
        Console.WriteLine($"Area of Trapezium is {((Base1 + Base2) * Height) / 2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Figure[] figures = new Figure[] {
            new Rectangle(5, 10),
            new Circle(7),
            new RightTriangle(3, 4),
            new Trapezium(5, 10, 6)
        };
        foreach (var figure in figures)
        {
            figure.Area();
        }
    }
}