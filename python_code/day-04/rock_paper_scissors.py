"""
100 Days of code challange,
Day 4 project : Rock Paper Scissors
"""

import random

ROCK = r"""
    _______________________________________________________________________
    /_\_/_\_/_\_/_\_/_\_/_\_/_\_/_\_/_\_/_\_/_\_/_\_/_\_/_\_/_\_/_\_/_\_/_\
                        ..oooooo...oo.......ooooo...
                        ..oo.......oo.......oo..oo..
    ___ ___              ..oooo.....oo.......ooooo...             ___ ___
    |ooo|ooo|             ..oo.......oo.......oo......______      |ooo|ooo|
    |===|===|             ..oooooo...oooooo...oo.....|##:[~]|     |===|===|
    |(O)|(O)|    -,-\   Q ,      ___                _|, Q :!|=m   |(O)|(O)|
    |(O)|(O)|    / -..\/H'=i=   |###|   Q .         / .-/|::=m/   |(O)|(O)|
    |mmm|mmm|___'|__|_,-.[]|\\__|###|__/W\_\_______MKm~'/--=m/)___|mmm|mmm|
    '======='    |  |(apx) |  `~'===' (`&}=|"    _ {|\ /|   /\(   '======='
    `~.__,-._/'\/'\`-' /'\  '._   ,'`}\ |    [M\)|-\| \ /--\'._.~
                            .  `~(_ / //'\
                                '._MMm ,-._mMM
    _______________________________`~-'____________________________________

"""


def rock_paper_scissors():
    """
    Rock Paper Scissors Game
    """
    print(ROCK)
    print("Welcome to Rock Paper Scissors Game.")
    print("Your mission is to win the game.")

    user_choice = input(
        'What do you choose? Type "rock", "paper" or "scissors": \n'
    ).lower()

    computer_choice = random.choice(["rock", "paper", "scissors"])
    print(f"Computer chose: {computer_choice}")

    if user_choice == computer_choice:
        print("It's a tie!")
    elif (
        (user_choice == "rock" and computer_choice == "scissors")
        or (user_choice == "paper" and computer_choice == "rock")
        or (user_choice == "scissors" and computer_choice == "paper")
    ):
        print("You win!")
    else:
        print("You lose!")


if __name__ == "__main__":
    rock_paper_scissors()
