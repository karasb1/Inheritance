namespace Inheritance;

public class Passport
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Country { get; set; }
    public string PassportNumber { get; set; }
    public DateTime ExpirationDate { get; set; }
    public string Nationality { get; set; }
    public string DateOfBirth { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Surname: {Surname}");
        Console.WriteLine($"Country: {Country}");
        Console.WriteLine($"Passport Number: {PassportNumber}");
        Console.WriteLine($"Expiration Date: {ExpirationDate.ToShortDateString()}");
        Console.WriteLine($"Nationality: {Nationality}");
        Console.WriteLine($"Date of Birth: {DateOfBirth}");
    }
}

public class ForeignPassport : Passport
{
    public string Visa { get; set; }
    public string VisaNumber { get; set; }
    public DateTime VisaExpirationDate { get; set; }

    public void ShowVisaInfo()
    {
        Console.WriteLine($"Visa: {Visa}");
        Console.WriteLine($"Visa Number: {VisaNumber}");
        Console.WriteLine($"Visa Expiration Date: {VisaExpirationDate.ToShortDateString()}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Passport passport = new Passport
        {
            Name = "John",
            Surname = "Doe",
            Country = "USA",
            PassportNumber = "123456789",
            ExpirationDate = new DateTime(2025, 12, 31),
            Nationality = "American",
            DateOfBirth = "01/01/1990"
        };
        passport.ShowInfo();
        Console.WriteLine();
        
        ForeignPassport foreignPassport = new ForeignPassport
        {
            Name = "Jane",
            Surname = "Smith",
            Country = "Canada",
            PassportNumber = "987654321",
            ExpirationDate = new DateTime(2026, 12, 31),
            Nationality = "Canadian",
            DateOfBirth = "02/02/1992",
            Visa = "Tourist",
            VisaNumber = "V123456",
            VisaExpirationDate = new DateTime(2024, 12, 31)
        };
        foreignPassport.ShowInfo();
        foreignPassport.ShowVisaInfo();
    }
}