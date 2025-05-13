namespace Inheritance;

public class Money
{
    public int Wholepart { get; set; }
    public int FractionalPart { get; set; }
    public Money(int wholepart, int fractionalPart)
    {
        Wholepart = wholepart;
        FractionalPart = fractionalPart;
    }
    public void PrintSum()
    {
        if (FractionalPart >= 100)
        {
            Wholepart += FractionalPart / 100;
            FractionalPart = FractionalPart % 100;
        }
        Console.WriteLine($"Whole part: {Wholepart}, Fractional part: {FractionalPart}");
    }
}

public class Product : Money
{
    public string Name { get; set; }
    public int Discount { get; set; }
    public Product(string name, int wholepart, int fractionalPart, int discount) : base(wholepart, fractionalPart)
    {
        Name = name;
        Discount = discount;
    }
    public void ReducePrice()
    {
        int total = Wholepart * 100 + FractionalPart;
        total -= (total * Discount) / 100;
        Wholepart = total / 100;
        FractionalPart = total % 100;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Money money = new Money(10, 150);
        money.PrintSum();
        Console.WriteLine();

        Product product = new Product("Laptop", 1000, 50, 10);
        product.PrintSum();
        product.ReducePrice();
        product.PrintSum();
    }
}