using Classes;

/* Main Global Scope */
Player player = new Player();
Opponent comp = new Opponent();
int totalWins = PrintWelcome();
Console.WriteLine($"{totalWins}");

int PrintWelcome() {
    int result = 0;
    string totalWins = "";
    Console.WriteLine("Welcome to Command-Line Rock Paper Scissors.");
    Console.WriteLine("Play against the computer");
    Console.WriteLine("Enter the number of total wins");
    Console.WriteLine("Example: enter [5] for best of five");
    Console.WriteLine("Total Wins: ");

    while(true) {
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
}