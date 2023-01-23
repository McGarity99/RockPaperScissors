namespace Classes;

public class Player {
    public int victories {get; set;}
    public Player() {
        victories = 0;
    }

    public int PromptMove() {
        int result = 0;
        char input;
        Console.Write("Enter your move: [r]ock, [p]aper, [s]cissors : ");
        while (true) {
            try {
                input = char.ToLower(Console.ReadLine()[0]);
                if (isValid(input)) {
                    switch (input) {
                    case 'r':
                        result = 0;
                        break;
                    case 'p':
                        result = 1;
                        break;
                    default:
                        result = 2;
                        break;
                    }
                    break;
                } else throw new Exception();
            } catch (Exception e) {
                Console.WriteLine("Invalid Value. Try again.");
            }
        }
        return result;
    }   //get the user's move input and map it to int

    private bool isValid(char moveChar) {
        return (moveChar == 'r' || moveChar == 'p' || moveChar == 's');
    }   //determine if user's move is a valid letter

}