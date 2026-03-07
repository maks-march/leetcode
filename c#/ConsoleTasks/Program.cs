namespace ConsoleTasks;

public class Program
{
    public static void Main(string[] args)
    {
        
    }
    
    public void task2()
    {
        var task = new Task2();
    }
    
    public void task1()
    {
        var task = new Task1();
        var s = Console.ReadLine() ?? string.Empty;
        var result = task.MinFlips(s);
        Console.WriteLine(result);
    }
}