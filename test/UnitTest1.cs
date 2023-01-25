namespace kata_game_of_life_tests;

public class UnitTest1
{
    private readonly Universe _universeOneByOne = new Universe(1,1);
    
    [Fact]
    public void UniverseExist()
    {
        Assert.NotNull(_universeOneByOne);
    }

    [Fact]
    public void Universe_has_two_dimensions()
    {
        Assert.Equal(2, _universeOneByOne.Dimensions.Rank);
    }

    [Fact]
    public void Universe_has_dimensions_are_one_by_one()
    {
        Assert.Equal(1, _universeOneByOne.Dimensions.GetLength(0));
        Assert.Equal(1, _universeOneByOne.Dimensions.GetLength(1));
    }

    [Fact]
    public void One_by_one_universe_has_a_dead_cell_at_the_beginning()
    {
        Assert.Equal(Universe.Dead, _universeOneByOne.Dimensions[0,0]);
    }

    [Fact]
    public void Universe_can_give_life_to_a_cell()
    {
        _universeOneByOne.GiveLifeTo(0, 0);
        Assert.Equal(Universe.Alive, _universeOneByOne.Dimensions[0,0]);
    }
    
    [Fact]
    public void Universe_can_take_life_from_a_cell()
    {
        _universeOneByOne.GiveLifeTo(0, 0);
        _universeOneByOne.TakeLifeFrom(0, 0);
        Assert.Equal(Universe.Dead, _universeOneByOne.Dimensions[0,0]);
    }
}