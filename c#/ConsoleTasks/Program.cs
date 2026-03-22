using ConsoleTasks.SlidingWindow;

namespace ConsoleTasks;

public class Program
{
    public static void Main(string[] args)
    {
        var t = new MinimumWindowSubstring();
        var r = t.MinWindow("ADOBECODEBANCADOBECODEBANCADOBECODEBANCADOBECODEBANCADOBECODEBANCADOBECODEBANCADOBECODEBANCADOBECODEBANCADOBECODEBANCADOBECODEBANCADOBECODEBANCADOBECODEBANCADOBECODEBANC", "ABCABCABCABCABCABCABC");
        Console.WriteLine(r);
    }
}