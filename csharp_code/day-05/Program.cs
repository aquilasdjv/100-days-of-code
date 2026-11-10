public class Program
{
    static void Main(string[] args)
    {
        PasswordGenerator passwordGenerator = new PasswordGenerator();
        passwordGenerator.GeneratePassword();
    }
}

public class PasswordGenerator
{
    public void GeneratePassword()
    {
        List<char> minuscules = Enumerable.Range('a', 26).Select(i => (char)i).ToList();
        List<char> majuscules = Enumerable.Range('A', 26).Select(i => (char)i).ToList();
        List<char> letters = minuscules.Concat(majuscules).ToList();
        List<char> digits = Enumerable.Range('0', 10).Select(i => (char)i).ToList();
        List<char> specialCharacters = new List<char> { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '[', ']', '{', '}', ';', ':', ',', '.', '<', '>', '/', '?', '|', '\\' };

        Console.WriteLine("Welcome to the Password Generator!");
        int nrOfLetters = int.Parse(GetUserInput("Enter the number of letters: "));
        int nrOfDigits = int.Parse(GetUserInput("Enter the number of digits: "));
        int nrOfSpecialCharacters = int.Parse(GetUserInput("Enter the number of special characters: "));

        List<char> passwordCharacters = new List<char>();
        passwordCharacters.AddRange(letters.OrderBy(x => Guid.NewGuid()).Take(nrOfLetters));
        passwordCharacters.AddRange(digits.OrderBy(x => Guid.NewGuid()).Take(nrOfDigits));
        passwordCharacters.AddRange(specialCharacters.OrderBy(x => Guid.NewGuid()).Take(nrOfSpecialCharacters));

        Random.Shared.Shuffle(System.Runtime.InteropServices.CollectionsMarshal.AsSpan(passwordCharacters));

        string password = new string(passwordCharacters.ToArray());

        Console.WriteLine($"Your generated password is: {password}");
    }

    private string GetUserInput(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }
}
