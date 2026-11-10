public class Program
{
    static void Main(string[] args)
    {
        TreasureIsland game = new TreasureIsland();
        game.PlayGame();
    }
}

public class TreasureIsland
{
    public void PlayGame()
    {
        Console.WriteLine("""
            *******************************************************************************

                                    _.--.
                                _.-'_:-'||
                            _.-'_.-::::'||
                    _.-:'_.-::::::'  ||
                    .'`-.-:::::::'     ||
                    /.'`;|:::::::'      ||_
                ||   ||::::::'     _.;._'-._
                ||   ||:::::'  _.-!oo @.!-._'-.
                \\'.  ||:::::.-!()oo @!()@.-'_.|
                    '.'-;|:.-'.&$@.& ()$%-'o.'\\\\U||
                    `>'-.!@%()@'@_%-'_.-o _.|'||
                    ||-._'-.@.-'_.-' _.-o  |'||
                    ||=[ '-._.-\\\\U/.-'    o |'||
                    || '-.]=|| |'|      o  |'||
                    ||      || |'|        _| ';
                    ||      || |'|    _.-'_.-'
                    |'-._   || |'|_.-'_.-'
                        '-._'-.|| |' `_.-'
                            '-.||_/.-' 
                            
            ******************************************************************************
            """);
        Console.WriteLine("Welcome to Treasure Island.");
        Console.WriteLine("Your mission is to find the treasure.");

        string choice1 = GetUserInput("You're at a cross road. Where do you want to go? Type 'left' or 'right'");
        if (choice1.ToLower() == "left")
        {
            string choice2 = GetUserInput("You come to a lake. There is an island in the middle of the lake. Type 'wait' to wait for a boat. Type 'swim' to swim across.");
            if (choice2.ToLower() == "wait")
            {
                string choice3 = GetUserInput("You arrive at the island unharmed. There is a house with 3 doors. One red, one yellow and one blue. Which color do you choose?");
                if (choice3.ToLower() == "red")
                {
                    Console.WriteLine("It's a room full of fire. Game Over.");
                }
                else if (choice3.ToLower() == "yellow")
                {
                    Console.WriteLine("Duty one! You found my bed! You Win! Climb in and take a nap after some fun. You deserve it.");
                }
                else if (choice3.ToLower() == "blue")
                {
                    Console.WriteLine("You enter a room of beasts. Game Over.");
                }
                else
                {
                    Console.WriteLine("You chose a door that doesn't exist. Game Over.");
                }
            }
            else
            {
                Console.WriteLine("You get attacked by an angry trout. Game Over.");
            }
        }
        else
        {
            Console.WriteLine("You fell into a hole. Game Over.");
        }
    }

    private string GetUserInput(string prompt)
    {
        Console.WriteLine(prompt);
        return Console.ReadLine();
    }
}
