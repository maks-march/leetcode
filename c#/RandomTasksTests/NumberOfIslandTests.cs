using FluentAssertions;
using RandomTasks;

namespace RandomTasksTests;

[TestFixture]
public class NumberOfIslandTests
{
    [Test]
    public void BaseTest()
    {
        string[][] grid = [
            ["1","1","1","1","0"],
            ["1","1","0","1","0"],
            ["1","1","0","0","0"],
            ["0","0","0","0","0"]
        ];
        char[][] theGrid = grid.Select(x => x.Select(y => y[0]).ToArray()).ToArray();
        NumberOfIslands.NumIslands(theGrid).Should().Be(1);
    }
}