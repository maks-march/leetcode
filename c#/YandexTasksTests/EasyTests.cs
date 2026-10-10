using FluentAssertions;
using YandexTasks.Easy;

namespace YandexTasksTests;

[TestFixture]
public class EasyTests
{
    [Test]
    public void MedianElement_Test()
    {
        MedianElement.Solve("0 -50 100").Should().Be(0);
    }

    [Test]
    public void KnightMove_Test()
    {
        KnightMove.Solve(31, 34).Should().Be(293930);
    }

}
