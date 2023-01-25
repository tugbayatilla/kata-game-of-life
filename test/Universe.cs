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

    public (int numberOfDeadNeighbors, int numberOfAliveNeighbors) GetNumberOfDeadAndAliveNeighborsOf(int x, int y)
    {
        var numberOfDeadNeighbors = 0;
        var numberOfAliveNeighbors = 0;


        var offsets = new int[,]
        {
            {1,0},
            {1,1},
            {0,1},
            {-1,1},
            {-1,0},
            {-1,-1},
            {0,-1},
            {1,-1}
        };

        offsets.forEach((first, second) =>
        {
            if (!IsValidDimensionWithOffset(x, y, first, second)) return;
            
            var neighbor = Dimensions[x + first, y + second];
            if (neighbor == 1) numberOfAliveNeighbors++;
            else numberOfDeadNeighbors++;
        });


        return (numberOfDeadNeighbors, numberOfAliveNeighbors);
    }

    private bool IsValidDimensionWithOffset(int x, int y, int first, int second)
    {
        try
        {
            var _ = Dimensions[x + first, y + second];
            return true;
        }
        catch
        {
            return false;
        }
    }
}

public static class ArrayExtensions
{
    public static void forEach(this int[,] array, Action<int, int> action)
    {
        for (var row = 0; row < array.GetLength(0); row++)
        {
            var temp = new int[2];
            for (var col = 0; col < array.GetLength(1); col++)
            {
                temp[col] = array[row,col];
            }

            action(temp[0], temp[1]);
        }
    }
}
