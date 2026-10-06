using Base75.PriorityQueue;

namespace RandomTasksTests.PriorityQueue;

public class PriorityQueueTests
{
    private MedianFinder _task;

    [SetUp]
    public void Setup()
    {
        _task = new ();
    }

    [Test]
    public void Test()
    {
        _task.AddNum(-1);
        _task.AddNum(-2);
        _task.AddNum(-3);
        Console.WriteLine(_task.FindMedian());
    }
}