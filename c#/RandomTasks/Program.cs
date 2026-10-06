namespace RandomTasks;

public class Program
{
    public static void Main(string[] args)
    {
        
    }
    
    public void task4()
    {
        var task = new Task4();
        var nums = new[] { 11, 12, 9, 8 };
        var strings = nums.Select(x => Convert.ToString(x, 2)).ToArray();
        var res = task.FindDifferentBinaryString(strings);
        Console.WriteLine(res);
    }
    
    public void task1()
    {
        var task = new Task1();
        var s = Console.ReadLine() ?? string.Empty;
        var result = task.MinFlips(s);
        Console.WriteLine(result);
    }
}