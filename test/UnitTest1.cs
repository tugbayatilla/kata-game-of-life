namespace kata_game_of_life_tests;

public class UnitTest1
{
    [Fact]
    public void UniverseExist()
    {
        var universe = new Universe();
        Assert.NotNull(universe);
    }
}