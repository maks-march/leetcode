using FluentAssertions;
using RandomTasks;

namespace RandomTasksTests;

[TestFixture]
public class LongestMountainTests
{
    [Test]
    public void BaseTest()
    {
        int[] inp = [0, 1, 0];
        LongestMountain.FindLongestMountain(inp).Should().Be(3);
    }
}