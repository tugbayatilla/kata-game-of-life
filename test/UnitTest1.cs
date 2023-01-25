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
    
    
}