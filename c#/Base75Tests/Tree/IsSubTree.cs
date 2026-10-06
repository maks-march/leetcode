using Base75.Trees;
using FluentAssertions;

namespace RandomTasksTests.Tree;

public class IsSubTreeTests
{
    private IsSubTree _task;
    private TreeNode[] _trees;

    [SetUp]
    public void Setup()
    {
        _task = new ();
        _trees = new TreeNode[]
        {
            TreeNode.ToTree(new() { 0, 1, 2, 3, 4, 5, 6 }),
            TreeNode.ToTree(new() { 1, 3, 4 }),
            TreeNode.ToTree(new() { 3, 4, 5, 1, 2, null, null, null, null, 0 }),
            TreeNode.ToTree(new() { 4, 1, 2 }),
            TreeNode.ToTree(new() { 0 }),
            TreeNode.ToTree(new() { 0 }),
        };
    }

    [TestCase(0, 1, true)]
    [TestCase(4, 5, true)]
    [TestCase(2, 3, false)]
    public void IsSubtree_Test(int p, int q, bool expected)
    {
        _task.IsSubtree(_trees[p], _trees[q]).Should().Be(expected);
    }
}