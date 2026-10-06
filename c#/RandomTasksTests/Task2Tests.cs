using RandomTasks;

namespace RandomTasksTests;

[TestFixture]
public class Task2Tests
{
    private Task2 _task;
    
    [SetUp]
    public void Setup()
    {
        _task = new Task2();
    }
    
    [TestCase("1001", ExpectedResult = false)]
    [TestCase("110", ExpectedResult = true)]
    [TestCase("1", ExpectedResult = true)]
    public bool CheckOnesSegment_DoSimple(string s)
    {
        return _task.CheckOnesSegment(s);
    }
}