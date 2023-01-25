namespace kata_game_of_life_tests;

public class UnitTest1
{
    private readonly Universe _universe = new Universe(1,1);

    [Fact]
    public void UniverseExist()
    {
        Assert.NotNull(_universe);
    }
    
    [Fact]
    public void Universe_has_two_dimensions()
    {
        Assert.Equal(2, _universe.Dimensions.Rank);
    }
    
    [Fact]
    public void Universe_has_dimensions_are_one_by_one()
    {
        Assert.Equal(1, _universe.Dimensions.GetLength(0));
        Assert.Equal(1, _universe.Dimensions.GetLength(1));
    }
    
    
}