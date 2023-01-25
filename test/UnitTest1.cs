namespace kata_game_of_life_tests;

public class UnitTest1
{
    [Fact]
    public void UniverseExist()
    {
        var universe = new Universe();
        Assert.NotNull(universe);
    }
    
    [Fact]
    public void Universe_has_two_dimensions()
    {
        var universe = new Universe();
        Assert.Equal(2, universe.Dimensions.Rank);
    }
    
    [Fact]
    public void Universe_has_dimensions_are_one_by_one()
    {
        var universe = new Universe(1,1);
        Assert.Equal(1, universe.Dimensions.GetLength(0));
        Assert.Equal(1, universe.Dimensions.GetLength(1));
    }
    
    
}