using Classes;

/* Main Global Scope */
Player player = new Player();
Opponent comp = new Opponent();
int totalWins = PrintWelcome();
int playerMove;
int compMove;

while (player.victories < (totalWins/2) + 1 && comp.victories < (totalWins/2) + 1) {
    playerMove = player.PromptMove();
    compMove = comp.getMove();

    Console.WriteLine($"You chose:\t{MoveToString(playerMove)}");
    Console.Write("Comp chose:\t");
    Thread.Sleep(1000);
    Console.Write($"{MoveToString(compMove)}\n");
    Console.Write("Outcome:\t");
    Thread.Sleep(1000);
    Console.WriteLine($"{DetermineOutcome(playerMove, compMove, player, comp)}");
    Thread.Sleep(750);

    PrintScores(player, comp, (totalWins/2) + 1);

}   //main game loop

if (player.victories > comp.victories) {
    Console.WriteLine("YOU WON THE GAME!");
} else if (player.victories < comp.victories) {
    Console.WriteLine("COMP WON THE GAME! Better luck next time.");
} else if (player.victories == comp.victories) {
    Console.WriteLine("IT'S A DRAW!");
}   //determining winner and printing message

int PrintWelcome() {
    int result = 0;
    string totalWins = "";
    Console.WriteLine("Welcome to Command-Line Rock Paper Scissors.");
    Console.WriteLine("Play against the computer");
    Console.WriteLine("Enter the number of total wins");
    Console.WriteLine("Example: enter [5] for best of five");
    Console.Write("Total Wins: ");

    while (true) {
        try {
            totalWins = Console.ReadLine();
            result = Int32.Parse(totalWins);
            if (result > 0 && result <= int.MaxValue) {
                break;
            } else {
                throw new OverflowException("Invalid input");
            }
        } catch (FormatException e) {
            Console.WriteLine("Error: Invalid Value. Try again.");
        } catch (OverflowException e) {
            Console.WriteLine("Error: Invalid Value. Try again.");
        }
    } // while-loop to validate input

    return result;
}   //print intro to game

string MoveToString(int move) {
    string theMove = "";
    switch (move) {
        case 0:
            theMove = "Rock";
            break;
        case 1:
            theMove = "Paper";
            break;
        default:
            theMove = "Scissors";
            break;
    }
    return theMove;
}   //get string representation of the move int

string DetermineOutcome(int playerMove, int compMove, Player plyr, Opponent comp) {
    string outcome = "";
    if (playerMove == compMove) {
        outcome = "It's a DRAW";
    } else if (playerMove == 0 && compMove == 1) {
        outcome = "Comp WINS";
        comp.victories++;
    } else if (playerMove == 0 && compMove == 2) {
        outcome = "You WIN";
        plyr.victories++;
    } else if (playerMove == 1 && compMove == 0) {
        outcome = "You WIN";
        plyr.victories++;
    } else if (playerMove == 1 && compMove == 2) {
        outcome = "Comp WINS";
        comp.victories++;
    } else if (playerMove == 2 && compMove == 0) {
        outcome = "Comp WINS";
        comp.victories++;
    } else if (playerMove == 2 && compMove == 1) {
        outcome = "You WIN";
        plyr.victories++;
    }
    return outcome;
}   //determine outcome based on rules of Rock Paper Scissors

void PrintScores(Player plyr, Opponent comp, int target) {
    Console.WriteLine("");
    Console.Write($"Player Points:\t{plyr.victories}\n");
    Console.Write($"Comp Points:\t{comp.victories}\n");
    Console.WriteLine($"Points to Win:\t{target}\n");
}   //print the player's and comp's scores after every turn