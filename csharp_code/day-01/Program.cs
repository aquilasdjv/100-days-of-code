public class Program
{
    static void Main(string[] args)
    {
        BandNameGenerator.GenerateBandName();
    }
}


public class BandNameGenerator
{
    public static void GenerateBandName()
    {
        Console.WriteLine("Welcome to the Band Name Generator!");
        Console.Write("What's the name of your city? ");
        string city = Console.ReadLine();

        Console.Write("What's your favorite animal? ");
        string animal = Console.ReadLine();

        string bandName = $"{city} {animal}";
        Console.WriteLine($"Your band name could be: {bandName}");
    }
}
