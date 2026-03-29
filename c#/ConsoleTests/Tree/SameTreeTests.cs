using ConsoleTasks.Trees;
using FluentAssertions;

namespace ConsoleTests.Tree;

public class SameTreeTests
{
    private SameTree _task;
    private TreeNode[] _trees;

    [SetUp]
    public void Setup()
    {
        _task = new ();
        _trees = new TreeNode[]
        {
            TreeNode.ToTree(new() { 0, 1, 2, 3, 4, 5, 6 }),
            TreeNode.ToTree(new() { 0, 1, 2, 3, 4, 5, 6 }),
            TreeNode.ToTree(new() { 0, 1, 2, 3, 4, 5, 7 }),
            TreeNode.ToTree(new() { 0, -5 }),
            TreeNode.ToTree(new() { 0, -8 }),
        };
    }

    [TestCase(0, 1, true)]
    [TestCase(1, 2, false)]
    [TestCase(3, 4, false)]
    [TestCase(1, 3, false)]
    public void IsSameTree_Test(int p, int q, bool expected)
    {
        _task.IsSameTree(_trees[p], _trees[q]).Should().Be(expected);
    }
}