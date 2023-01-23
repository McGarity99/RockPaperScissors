namespace Classes;

public class Opponent {
    public int victories {get; set;}
    private static Random rd = new Random();
    public Opponent() {
        victories = 0;
    }

    public int getMove() {
        return rd.Next(0, 3);
    }   //generate random move

}