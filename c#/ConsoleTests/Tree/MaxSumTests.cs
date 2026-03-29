using ConsoleTasks.Trees;
using FluentAssertions;

namespace ConsoleTests.Tree;

public class MaxSumTests
{
    private MaximumPathSum _task;
    private TreeNode[] _trees;

    [SetUp]
    public void Setup()
    {
        _task = new ();
        _trees = new []
        {
            TreeNode.ToTree(new() { -10,9,20,null,null,15,7 }),
            TreeNode.ToTree(new() { 1 }),
            TreeNode.ToTree(new() { -2, -1 }),
            TreeNode.ToTree(new() { 5,4,8,11,null,13,4,7,2,null,null,null,null,null,1 }),
        };
    }

    [TestCase(0, 42)]
    [TestCase(1, 1)]
    [TestCase(2, -1)]
    [TestCase(3, 48)]
    public void MaxPathSum_Test(int i, int expected)
    {
        _task.MaxPathSum(_trees[i]).Should().Be(expected);
    }

    [Test]
    public void JustTest()
    {
        var t = new SerializeAndDeserialzieTree();
        var s = t.serialize(_trees[0]);
        Console.WriteLine(s);
        // var l = t.deserialize(s);
        // s = t.serialize(l);
        // Console.WriteLine(s);
    }
}