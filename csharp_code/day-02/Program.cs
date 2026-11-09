using System;

public class Program
{
    static void Main(string[] args)
    {
        TipCalculator.CalculateTip();
    }
}

public class TipCalculator
{
    public static void CalculateTip()
    {
        Console.WriteLine("Welcome to the tip calculator.");
        Console.Write("What was the total bill? $");
        double bill = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("What percentage tip would you like to give? 10, 12, or 15? ");
        int tip = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("How many people to split the bill? ");
        int people = int.Parse(Console.ReadLine() ?? "0");

        double tipAsPercent = tip / 100.0;
        double totalTipAmount = bill * tipAsPercent;
        double totalBill = bill + totalTipAmount;
        double billPerPerson = totalBill / people;

        Console.WriteLine($"Each person should pay: ${billPerPerson:F2}");
    }
    
}
