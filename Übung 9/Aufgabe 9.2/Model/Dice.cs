public class Dice {
    private static Random random = new Random();

    public int Roll(int low, int high) {
        return random.Next(low, high + 1);
    }
}