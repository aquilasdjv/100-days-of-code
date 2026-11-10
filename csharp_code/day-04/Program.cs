public class Program
{
    static void Main(string[] args)
    {
        RockPaperScissors game = new RockPaperScissors();
        game.PlayGame();
    }
}

public class RockPaperScissors
{
    /***
        * This method plays the Rock Paper Scissors game.
        * It prompts the user for their choice, generates a random choice for the computer,
        * and determines the winner based on the rules of the game.
        */
    public void PlayGame()
    {
        Console.WriteLine("Welcome to Rock Paper Scissors Game.");
        Console.WriteLine("Your mission is to win the game.");

        string userChoice = GetUserInput("What do you choose? Type 'rock', 'paper', or 'scissors': ");
        string computerChoice = GetComputerChoice();

        if (userChoice.ToLower() == computerChoice)
        {
            Console.WriteLine("It's a draw! Both chose " + userChoice);
        }
        else if ((userChoice.ToLower() == "rock" && computerChoice == "scissors") ||
                (userChoice.ToLower() == "paper" && computerChoice == "rock") ||
                (userChoice.ToLower() == "scissors" && computerChoice == "paper"))
        {
            Console.WriteLine("You win! " + userChoice + " beats " + computerChoice);
        }
        else
        {
            Console.WriteLine("You lose! " + computerChoice + " beats " + userChoice);
        }
    }

    private string GetUserInput(string prompt)
    {
        Console.WriteLine(prompt);
        return Console.ReadLine();
    }

    private string GetComputerChoice()
    {
        string[] choices = { "rock", "paper", "scissors" };
        Random random = new Random();
        int randomIndex = random.Next(choices.Length);
        return choices[randomIndex];
    }
}

