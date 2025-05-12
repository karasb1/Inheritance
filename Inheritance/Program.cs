namespace Inheritance;

public class MusicalInstrument
{
    public string Name { get; set; }
    public string Weight { get; set; }
    public string Color { get; set; }
    
    public MusicalInstrument(string name, string weight, string color)
    {
        Name = name;
        Weight = weight;
        Color = color;
    }
}
public class Violin : MusicalInstrument
{
    public string Size { get; set; }
    public int Strings { get; set; } = 4;
    public Violin(string name, string weight, string color, string size) : base(name, weight, color)
    {
        Size = size;
    }
    public void Sound()
    {
        Console.WriteLine($"The {Name} makes a sound.");
    }

    public void Show()
    {
        Console.WriteLine($"Name: {Name}");
    }
    public void Desc()
    {
        Console.WriteLine($"Size: {Size}, Strings: {Strings}");
    }

    public void History()
    {
        Console.WriteLine("The violin is a string instrument that has been around for centuries. It is known for its beautiful sound and versatility in various music genres.");
    }
}
public class Trombone : MusicalInstrument
{
    public string Type { get; set; }
    public int Valves { get; set; } = 3;
    public Trombone(string name, string weight, string color, string type) : base(name, weight, color)
    {
        Type = type;
    }
    public void Sound()
    {
        Console.WriteLine($"The {Name} makes a sound.");
    }

    public void Show()
    {
        Console.WriteLine($"Name: {Name}");
    }
    public void Desc()
    {
        Console.WriteLine($"Type: {Type}, Valves: {Valves}");
    }

    public void History()
    {
        Console.WriteLine("The trombone is a brass instrument that has been used in various music genres. It is known for its unique slide mechanism and rich sound.");
    }
}
public class Ukulele : MusicalInstrument
{
    public string Size { get; set; }
    public int Strings { get; set; } = 4;
    public Ukulele(string name, string weight, string color, string size) : base(name, weight, color)
    {
        Size = size;
    }
    public void Sound()
    {
        Console.WriteLine($"The {Name} makes a sound.");
    }

    public void Show()
    {
        Console.WriteLine($"Name: {Name}");
    }
    public void Desc()
    {
        Console.WriteLine($"Size: {Size}, Strings: {Strings}");
    }

    public void History()
    {
        Console.WriteLine("The ukulele is a small guitar-like instrument that originated in Hawaii. It is known for its cheerful sound and is often used in Hawaiian music.");
    }
}
public class ViolinCello : MusicalInstrument
{
    public string Size { get; set; }
    public int Strings { get; set; } = 4;
    public ViolinCello(string name, string weight, string color, string size) : base(name, weight, color)
    {
        Size = size;
    }
    public void Sound()
    {
        Console.WriteLine($"The {Name} makes a sound.");
    }

    public void Show()
    {
        Console.WriteLine($"Name: {Name}");
    }
    public void Desc()
    {
        Console.WriteLine($"Size: {Size}, Strings: {Strings}");
    }

    public void History()
    {
        Console.WriteLine("The violin cello is a string instrument that is larger than a violin and has a deeper sound. It is commonly used in orchestras and chamber music.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Violin violin = new Violin("Violin", "1.5 kg", "Brown", "4/4");
        violin.Show();
        violin.Desc();
        violin.History();
        violin.Sound();

        Trombone trombone = new Trombone("Trombone", "2.5 kg", "Gold", "Tenor");
        trombone.Show();
        trombone.Desc();
        trombone.History();
        trombone.Sound();

        Ukulele ukulele = new Ukulele("Ukulele", "0.5 kg", "Blue", "Soprano");
        ukulele.Show();
        ukulele.Desc();
        ukulele.History();
        ukulele.Sound();

        ViolinCello violinCello = new ViolinCello("Violin Cello", "3 kg", "Black", "4/4");
        violinCello.Show();
        violinCello.Desc();
        violinCello.History();
        violinCello.Sound();
    }
}