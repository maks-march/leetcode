using ConsoleTasks.SlidingWindow;

namespace ConsoleTasks;

public class Program
{
    public static void Main(string[] args)
    {
        var t = "ab";
        var s = "a" + "b";
        var a = string.Format("{0}{1}", "a", "b");
        Console.WriteLine(object.ReferenceEquals(t, s));
        Console.WriteLine(object.ReferenceEquals(t, a));
    }
}