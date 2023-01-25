namespace kata_game_of_life_tests;

public class Universe
{
    public Universe(int x, int y)
    {
        Dimensions = new int[x, y];
    }

    public int[,] Dimensions { get; }
}