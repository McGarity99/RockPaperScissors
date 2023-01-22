namespace Classes;

public class Player {
    public int victories {get;}
    public Player() {
        victories = 0;
    }

    public int PromptMove() {
        int result = 0;
        Console.WriteLine("Enter your move: [r]ock, [p]aper, [s]cissors");
        
        return result;
    }

}