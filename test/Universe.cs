namespace kata_game_of_life_tests;

public class Universe
{
    public const int Alive = 1;
    public const int Dead = 0;

    public Universe(int x, int y)
    {
        Dimensions = new int[x, y];
    }

    public int[,] Dimensions { get; }

    public void GiveLifeTo(int x, int y)
    {
        Dimensions[x, y] = Alive;
    }

    public void TakeLifeFrom(int x, int y)
    {
        Dimensions[x, y] = Dead;
    }
}