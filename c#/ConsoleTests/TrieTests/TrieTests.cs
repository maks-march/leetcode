using ConsoleTasks.Trees;
using ConsoleTasks.Tries;

namespace ConsoleTests.TrieTests;

public class TrieTests
{
    private Trie _task;

    [SetUp]
    public void Setup()
    {
        _task = new ();
    }

    [Test]
    public void Test()
    {
        _task.Insert("app");
        _task.Insert("apple");
        _task.Insert("beer");
        _task.Insert("add");
        _task.Insert("jam");
        _task.Insert("rental");
        
        Console.WriteLine(_task.Search("app"));
        Console.WriteLine(_task.Search("ad"));
    }
}