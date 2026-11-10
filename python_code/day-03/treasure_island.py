"""
100 Days of code challange,
Day 3 project : Treasure Island
"""

TREASURE_MAP = r"""
*******************************************************************************

                            _.--.
                        _.-'_:-'||
                    _.-'_.-::::'||
               _.-:'_.-::::::'  ||
             .'`-.-:::::::'     ||
            /.'`;|:::::::'      ||_
           ||   ||::::::'     _.;._'-._
           ||   ||:::::'  _.-!oo @.!-._'-.
           \'.  ||:::::.-!()oo @!()@.-'_.|
            '.'-;|:.-'.&$@.& ()$%-'o.'\U||
              `>'-.!@%()@'@_%-'_.-o _.|'||
               ||-._'-.@.-'_.-' _.-o  |'||
               ||=[ '-._.-\U/.-'    o |'||
               || '-.]=|| |'|      o  |'||
               ||      || |'|        _| ';
               ||      || |'|    _.-'_.-'
               |'-._   || |'|_.-'_.-'
                '-._'-.|| |' `_.-'
                    '-.||_/.-' 
                    
******************************************************************************
"""


def treasure_island():
    """
    Treasure Island Game
    """
    print(TREASURE_MAP)
    print("Welcome to Treasure Island.")
    print("Your mission is to find the treasure.")

    choice1 = input(
        'You\'re at a cross road. Where do you want to go? Type "left" or "right" \n'
    ).lower()

    if choice1 == "left":
        choice2 = input(
            'You\'ve come to a lake. There is an island in the middle of the lake. Type "wait" to wait for a boat. Type "swim" to swim across. \n'
        ).lower()
        if choice2 == "wait":
            choice3 = input(
                "You arrive at the island unharmed. There is a house with 3 doors. One red, one yellow and one blue. Which color do you choose? \n"
            ).lower()
            if choice3 == "red":
                print("It's a room full of fire. Game Over.")
            elif choice3 == "yellow":
                print(
                    "You found my bed! You Win! Climb in and take a nap after some fun. You deserve it."
                )
            elif choice3 == "blue":
                print("You enter a room of beasts. Game Over.")
            else:
                print("You chose a door that doesn't exist. Game Over.")
        else:
            print("You get attacked by an angry trout. Game Over.")
    else:
        print("You fell into a hole. Game Over.")


if __name__ == "__main__":
    treasure_island()
